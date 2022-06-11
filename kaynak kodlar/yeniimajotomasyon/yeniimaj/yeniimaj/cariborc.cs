using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yeniimaj
{
    public partial class cariborc : Form
    {
        public cariborc()
        {
            InitializeComponent();
        }
        public string CARIID ="";
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void cariborc_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from CARI WHERE TUR='ALIS' OR TUR='SATIS'", baglanti);
            SqlDataReader DR = komut.ExecuteReader();

            while (DR.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR[2].ToString();
                item.Value = DR[0].ToString();
                combocari.Items.Add(item);

            }
            baglanti.Close();
        }
       

        private void combocari_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CARIID == "") { MessageBox.Show("cari seçiniz!"); return; }
            DataTable tablo1 = new DataTable();
            string query = "SELECT "+
                            "CARI.UNVAN as CARIUNVANI, " +
                            "CONVERT(varchar, MUHASEBEFIS.TARIH, 104) as TARIH, " +
                            "CASE WHEN (MUHASEBEFIS.TUR = 'ODEME' AND CARI.TUR='ALIS') OR (MUHASEBEFIS.TUR = 'SATIS' AND CARI.TUR='SATIS') THEN ISNULL(MUHASEBEFIS.GENELTOPLAM,0) ELSE 0 END as ALACAK, " +
                            "CASE WHEN (MUHASEBEFIS.TUR = 'ALIS' AND CARI.TUR='ALIS') OR (MUHASEBEFIS.TUR='ODEME' AND CARI.TUR='SATIS') THEN ISNULL(MUHASEBEFIS.GENELTOPLAM,0) ELSE 0 END as BORC " +
                            "FROM MUHASEBEFIS " +
                            "LEFT JOIN CARI ON CARI.CARIID = MUHASEBEFIS.CARI " +
                            "WHERE CARI ="+CARIID;
            SqlDataAdapter da1 = new SqlDataAdapter(query, baglanti);
            baglanti.Open();
            da1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
           

           
            DataTable tablo = new DataTable();
            var query1 = "select " +
                        "CARI.UNVAN as CARIUNVANI, " +
                        "CASE WHEN CARI.TUR='SATIS' THEN ISNULL(FAT.GENELTOPLAM,0) ELSE ISNULL(MAH.GENELTOPLAM,0) END as ALACAK, " +
                        "CASE WHEN CARI.TUR='ALIS' THEN ISNULL(FAT.GENELTOPLAM,0) ELSE ISNULL(MAH.GENELTOPLAM,0) END  as BORC, " +
                        "CASE WHEN CARI.TUR='SATIS' THEN ISNULL(MAH.GENELTOPLAM,0) - ISNULL(FAT.GENELTOPLAM,0) ELSE  ISNULL(FAT.GENELTOPLAM,0) - ISNULL(MAH.GENELTOPLAM,0) END as BAKIYE " +
                        "from CARI " +
                        "OUTER APPLY(SELECT SUM(GENELTOPLAM) as GENELTOPLAM FROM MUHASEBEFIS WHERE CARI.CARIID = CARI AND TUR IN ('ALIS','SATIS')) as FAT " +
                        "OUTER APPLY(SELECT SUM(GENELTOPLAM) as GENELTOPLAM FROM MUHASEBEFIS WHERE CARI.CARIID = CARI AND TUR = 'ODEME') as MAH " +
                        "WHERE CARI.CARIID ="+CARIID;
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(query1, baglanti);
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();

        }
    }
}
