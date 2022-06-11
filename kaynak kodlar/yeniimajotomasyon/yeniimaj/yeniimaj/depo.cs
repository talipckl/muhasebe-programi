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
    public partial class depo : Form
    {
        public string ARACID = "";
        public string PERSONELID = "";
        public string CARIID = "";
        public string TUR = "";

        
        public depo()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
       
        private void depo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeniimajservisDataSet5.MUHASEBEFIS' table. You can move, or remove it, as needed.
           // this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet5.MUHASEBEFIS);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

          

            comboarac.Items.Clear();
            combopersonel.Items.Clear();
            combotur.Items.Clear();

            ComboboxItem itemTA = new ComboboxItem();
            itemTA.Text = "ALIS";
            itemTA.Value = "ALIS";
            combotur.Items.Add(itemTA);

            ComboboxItem itemTS = new ComboboxItem();
            itemTS.Text = "SATIS";
            itemTS.Value = "SATIS";
            combotur.Items.Add(itemTS);

            ComboboxItem itemTG = new ComboboxItem();
            itemTG.Text = "GIDER";
            itemTG.Value = "GIDER";
            combotur.Items.Add(itemTG);

            ComboboxItem itemTH = new ComboboxItem();
            itemTH.Text = "HEPSİ";
            itemTH.Value = "";
            combotur.Items.Add(itemTH);


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from ARAC", baglanti);
            SqlDataReader DR2 = komut2.ExecuteReader();

            ComboboxItem itemA = new ComboboxItem();
            itemA.Text = "HEPSİ";
            itemA.Value = "";
            comboarac.Items.Add(itemA);

            while (DR2.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR2[1].ToString();
                item.Value = DR2[0].ToString();
                comboarac.Items.Add(item);

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from PERSONEL", baglanti);
            SqlDataReader DR3 = komut3.ExecuteReader();

            ComboboxItem itemP = new ComboboxItem();
            itemP.Text = "HEPSİ";
            itemP.Value = "";
            combopersonel.Items.Add(itemP);

            while (DR3.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR3[1].ToString();
                item.Value = DR3[0].ToString();
                combopersonel.Items.Add(item);

            }
            baglanti.Close();


           



        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboarac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARACID = (comboarac.SelectedItem as ComboboxItem).Value.ToString();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PERSONELID = (combopersonel.SelectedItem as ComboboxItem).Value.ToString();
        }
        Font baslık = new Font("Verdana",12,FontStyle.Bold);
        Font govde = new Font("Verdana", 12);
        SolidBrush sb = new SolidBrush(Color.Black);


        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygula = new Microsoft.Office.Interop.Excel.Application();
            uygula.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uygula.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                    range.Value2 = dataGridView1[i, j].Value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataTable tablo = new DataTable();
            string query = this.SearchBarQuery();
            SqlDataAdapter da = new SqlDataAdapter(query,baglanti);
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        public string SearchBarQuery()
        {
            var tarihQuery = "";
            var plakaQuery = "";
            var cariQuery = "";
            var turQuery = "";
            var personelQuery = "";

            var dt1 = DateTime.Parse(date1.Value.ToString());
            var dt2 = DateTime.Parse(date2.Value.ToString());

            tarihQuery = " MUHASEBEFIS.TARIH BETWEEN '"+dt1.Year+"-"+dt1.Month+"-"+dt1.Day+"' " +
                         " AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "'";
            if (CARIID != "")
            {
                cariQuery = " AND MUHASEBEFIS.CARI=" + CARIID+" ";
            }

            if (TUR != "") {
                turQuery = " AND MUHASEBEFIS.TUR='"+TUR+"'";
            }

            if (PERSONELID != "")
            {
                personelQuery = " AND MUHASEBEFIS.PERSONEL=" + PERSONELID + " ";
            }

            if (ARACID != "")
            {
                plakaQuery = " AND MUHASEBEFIS.ARACPLAKA=" + ARACID + " ";
            }


            string query = " SELECT " +
                          " MUHASEBEFIS.MUHASEBEID AS MUHASEBEID," +
                          " MUHASEBEFIS.TUR AS TUR," +
                          " CARI.UNVAN AS CARI," +
                          " PERSONEL.PERSONELADI + ' ' + PERSONEL.PERSONELSOYADI AS PERSONEL," +
                          " ARAC.PLAKA AS ARACPLAKA," +
                          " MUHASEBEFIS.MIKTAR AS MIKTAR," +
                          " MUHASEBEFIS.ACIKLAMA AS ACIKLAMA, " +
                          " MUHASEBEFIS.KDVSIZBIRIMFIYAT as KDVSIZBIRIMFIYAT," +
                          " MUHASEBEFIS.TASIMAUCRET AS TASIMAUCRETI," +
                          " MUHASEBEFIS.GENELTOPLAM as GENELTOPLAM," +
                          " CONVERT(varchar, MUHASEBEFIS.TARIH, 104) AS TARIH" +
                          " FROM MUHASEBEFIS" +
                          " LEFT JOIN CARI ON CARI.CARIID = MUHASEBEFIS.CARI" +
                          " LEFT JOIN PERSONEL ON PERSONEL.PERSONELID = MUHASEBEFIS.PERSONEL" +
                          " LEFT JOIN ARAC ON ARAC.ARACID = MUHASEBEFIS.ARACPLAKA" +
                          " WHERE " +tarihQuery+turQuery+personelQuery+cariQuery+plakaQuery;

            return query;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet5.MUHASEBEFIS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void combotur_SelectedValueChanged(object sender, EventArgs e)
        {
            TUR = (combotur.SelectedItem as ComboboxItem).Value.ToString();

            combocari.Items.Clear();

            baglanti.Open();
            SqlCommand comd = new SqlCommand("select * from CARI WHERE TUR='" + combotur.SelectedItem.ToString() + "'", baglanti);
            SqlDataReader drr = comd.ExecuteReader();

            while (drr.Read())
            {

                ComboboxItem item = new ComboboxItem();
                item.Text = drr[2].ToString();
                item.Value = drr[0].ToString();
                combocari.Items.Add(item);

            }


            baglanti.Close();
        }

        private void combocari_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet5.MUHASEBEFIS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
