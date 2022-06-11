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
    public partial class personelmaas : Form
    {
        public personelmaas()
        {
            InitializeComponent();
        }
        public string PERSONELID = "";
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void personelmaas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeniimajservisDataSet7.PERSONEL' table. You can move, or remove it, as needed.
            // this.pERSONELTableAdapter.Fill(this.yeniimajservisDataSet7.PERSONEL);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PERSONEL", baglanti);
            SqlDataReader DR = komut.ExecuteReader();

            while (DR.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR[1].ToString();
                item.Value = DR[0].ToString();
                combopersonel.Items.Add(item);

            }
            baglanti.Close();
        }

        public string SearchBarQuery()
        {
            var personelQuery = "";

            if (PERSONELID != "")
            {
                personelQuery = " PERSONEL.PERSONELID=" + PERSONELID + " ";
            }
            string query = "SELECT * FROM PERSONEL WHERE " + personelQuery;
            return query;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablo1 = new DataTable();
            string query = this.SearchBarQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(query, baglanti);
            baglanti.Open();
            da1.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
            baglanti.Close();
           

           
            DataTable tablo = new DataTable();
            var query1 = "select SUM(ISNULL(MUHASEBEFIS.GENELTOPLAM, 0)) as AVANS, MAX(ISNULL(PERSONEL.MAAS, 0)) as MAAS, MAX(ISNULL(PERSONEL.MAAS, 0)) - SUM(ISNULL(MUHASEBEFIS.GENELTOPLAM, 0)) as KALAN from PERSONEL left join MUHASEBEFIS on PERSONEL.PERSONELID = MUHASEBEFIS.PERSONEL AND MONTH(GETDATE()) = MONTH(MUHASEBEFIS.TARIH)left join CARI ON CARI.CARIID = MUHASEBEFIS.CARI where (CARI.UNVAN='PERSONEL MAAS' OR CARI.UNVAN='PERSONEL NAKİT AVANS') AND CARI.TUR='GIDER'AND PERSONEL.PERSONELADI = '" + combopersonel.Text.ToString() + "' GROUP BY PERSONEL.PERSONELADI";
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(query1, baglanti);
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();


        }

        private void combopersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
        }

        private void combopersonel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PERSONELID = (combopersonel.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
