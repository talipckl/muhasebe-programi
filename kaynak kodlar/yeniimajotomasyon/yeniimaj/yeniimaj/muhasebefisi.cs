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
    public partial class muhasebefisi : Form
    {
        public string PERSONELID = "";
        public string ARACID = "";
        public string CARIID = "";
        public string MUHASEBEID = "";
        public float depostokdurumu = 0;
        public Boolean stok = false;

        public string yazi;
        public muhasebefisi()
        {
            InitializeComponent();
        }
      
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                buttonkaydet.Enabled = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MUHASEBEFIS set TUR=@TUR, CARI=@CARI,PERSONEL=@PERSONEL,ARACPLAKA=@ARACPLAKA,MIKTAR=@MIKTAR,KDVSIZBIRIMFIYAT=@KDVSIZBIRIMFIYAT,ACIKLAMA=@ACIKLAMA,TASIMAUCRET=@TASIMAUCRET,GENELTOPLAM=@GENELTOPLAM,TARIH=@TARIH WHERE MUHASEBEID=@MUHASEBEID", baglanti);
                komut.Parameters.AddWithValue("@TUR", combotur.Text);
                komut.Parameters.AddWithValue("@CARI", CARIID);
                komut.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                komut.Parameters.AddWithValue("@ARACPLAKA", ARACID);
                komut.Parameters.AddWithValue("@MIKTAR", float.Parse(textmiktar.Text));
                komut.Parameters.AddWithValue("@KDVSIZBIRIMFIYAT", float.Parse(textkadevsesizbirimfiyat.Text));
                komut.Parameters.AddWithValue("@ACIKLAMA", richTextaciklama.Text);
                komut.Parameters.AddWithValue("@TASIMAUCRET", float.Parse(texttasımaucret.Text));
                komut.Parameters.AddWithValue("@GENELTOPLAM", float.Parse(textgeneltoplam.Text));
                komut.Parameters.AddWithValue("@TARIH", dateTarih.Value);
                komut.Parameters.AddWithValue("@MUHASEBEID", MUHASEBEID);
                SqlDataReader dr = komut.ExecuteReader();
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet3.MUHASEBEFIS);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Sil();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");
            }
            buttonkaydet.Enabled = true;
            baglanti.Close();
            
           

        }
        public String nowsearch()
        {
            var dt1 = DateTime.Now;
            var dt2 = DateTime.Now;
         
            var tarihQuery2 = " MUHASEBEFIS.TARIH BETWEEN '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "' " +
                         " AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "'";
            MessageBox.Show(tarihQuery2);

            string query2 = " SELECT " +
                         " MUHASEBEFIS.MUHASEBEID AS MUHASEBEID," +
                         " MUHASEBEFIS.TUR AS TUR," +
                         " CARI.UNVAN AS CARI," +
                         " PERSONEL.PERSONELADI + ' ' + PERSONEL.PERSONELSOYADI AS PERSONEL," +
                         " ARAC.PLAKA AS ARACPLAKA," +
                         " MUHASEBEFIS.MIKTAR AS MIKTAR," +
                         " MUHASEBEFIS.KDVSIZBIRIMFIYAT as KDVSIZBIRIMFIYAT," +
                         " MUHASEBEFIS.ACIKLAMA AS ACIKLAMA," + 
                         " MUHASEBEFIS.TASIMAUCRET AS TASIMAUCRETI," +
                         " MUHASEBEFIS.GENELTOPLAM as GENELTOPLAM," +
                         " CONVERT(varchar, MUHASEBEFIS.TARIH, 104) AS TARIH" +
                         " FROM MUHASEBEFIS" +
                         " LEFT JOIN CARI ON CARI.CARIID = MUHASEBEFIS.CARI" +
                         " LEFT JOIN PERSONEL ON PERSONEL.PERSONELID = MUHASEBEFIS.PERSONEL" +
                         " LEFT JOIN ARAC ON ARAC.ARACID = MUHASEBEFIS.ARACPLAKA" +
                         " WHERE " + tarihQuery2;

            return query2;
        }
        public string search()
        {
            char pad = '0';
            var dt1 = DateTime.Parse(date1.Value.ToString());
            var dt2 = DateTime.Parse(date2.Value.ToString());
            var tarihQuery = " MUHASEBEFIS.TARIH BETWEEN '" + dt1.Year + "-" + dt1.Month.ToString().PadLeft(2, pad) + "-" + dt1.Day.ToString().PadLeft(2, pad) + "' " +
                         " AND '" + dt2.Year + "-" +  dt2.Month.ToString().PadLeft(2, pad) + "-" + dt2.Day.ToString().PadLeft(2, pad) + "'";
            //MessageBox.Show(tarihQuery);

            string query = " SELECT " +
                         " MUHASEBEFIS.MUHASEBEID AS MUHASEBEID," +
                         " MUHASEBEFIS.TUR AS TUR," +
                         " CARI.UNVAN AS CARI," +
                         " PERSONEL.PERSONELADI + ' ' + PERSONEL.PERSONELSOYADI AS PERSONEL," +
                         " ARAC.PLAKA AS ARACPLAKA," +
                         " MUHASEBEFIS.MIKTAR AS MIKTAR," +
                         " MUHASEBEFIS.ACIKLAMA AS ACIKLAMA,"+
                         " MUHASEBEFIS.KDVSIZBIRIMFIYAT as KDVSIZBIRIMFIYAT," +
                         " MUHASEBEFIS.TASIMAUCRET AS TASIMAUCRETI," +
                         " MUHASEBEFIS.GENELTOPLAM as GENELTOPLAM," +
                         " CONVERT(varchar, MUHASEBEFIS.TARIH, 104) AS TARIH" +
                         " FROM MUHASEBEFIS" +
                         " LEFT JOIN CARI ON CARI.CARIID = MUHASEBEFIS.CARI" +
                         " LEFT JOIN PERSONEL ON PERSONEL.PERSONELID = MUHASEBEFIS.PERSONEL" +
                         " LEFT JOIN ARAC ON ARAC.ARACID = MUHASEBEFIS.ARACPLAKA" +
                         " WHERE " + tarihQuery;

            return query;
        }
        private void goster()
        {
            DataTable tablo = new DataTable();
            string query2 = this.nowsearch();
            SqlDataAdapter da = new SqlDataAdapter(query2, baglanti);
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            string query = this.search();
            SqlDataAdapter da = new SqlDataAdapter(query, baglanti);
            baglanti.Open();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();




        }
        private void stokcontrol()
        {
            float alis, satis, durum;
            alis = 0;
            satis = 0;

            baglanti.Open();
            SqlCommand cm = new SqlCommand("SELECT ISNULL(SUM(MIKTAR),0) AS GT FROM MUHASEBEFIS WHERE TUR='ALIS'", baglanti);
            SqlDataReader der = cm.ExecuteReader();
            
            while (der.Read())
            {

                
                alis = float.Parse(der[0].ToString());


            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand cm2 = new SqlCommand("SELECT ISNULL(SUM(MIKTAR),0) AS GT FROM MUHASEBEFIS WHERE TUR='SATIS'", baglanti);
            SqlDataReader der2 = cm2.ExecuteReader();
            while (der2.Read())
            {

                
                satis = float.Parse(der2[0].ToString());


            }
            baglanti.Close();


            durum = alis - satis;
            depostokdurumu = durum;
        }
        private void muhasebefisi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeniimajservisDataSet3.MUHASEBEFIS' table. You can move, or remove it, as needed.
            this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet3.MUHASEBEFIS);
            textgeneltoplam.ReadOnly=true;
            goster();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            this.stokcontrol();

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

          

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from ARAC", baglanti);
            SqlDataReader DR2 = komut2.ExecuteReader();

            while (DR2.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR2[1].ToString();
                item.Value = DR2[0].ToString();
                comboarac.Items.Add(item);

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from CARI WHERE TUR='" + combotur.SelectedIndex.ToString() + "'", baglanti);
            SqlDataReader DR3 = komut3.ExecuteReader();

            while (DR3.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR3[2].ToString();
                item.Value = DR3[0].ToString();
                combocari.Items.Add(item);

            }


            baglanti.Close();
        }

        private void combopersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            PERSONELID = (combopersonel.SelectedItem as ComboboxItem).Value.ToString();
         
        }

        private void combotur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARACID = (comboarac.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString();
            
        }

        private void combotur_SelectedValueChanged(object sender, EventArgs e)
        {
            combocari.Items.Clear();
           
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from CARI WHERE TUR='" + combotur.SelectedItem.ToString() + "'", baglanti);
            SqlDataReader DR3 = komut3.ExecuteReader();

            while (DR3.Read())
            {

                ComboboxItem item = new ComboboxItem();
                item.Text = DR3[2].ToString();
                item.Value = DR3[0].ToString();
                combocari.Items.Add(item);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (combotur.Text== "" || combocari.Text == "" || combopersonel.Text == "" || 
                comboarac.Text == "" || textmiktar.Text == "" || 
                 textkadevsesizbirimfiyat.Text == "")
            {

                combotur.BackColor = Color.FromArgb(250, 106, 87);
                combocari.BackColor = Color.FromArgb(250, 106, 87);
                combopersonel.BackColor = Color.FromArgb(250, 106, 87);
                comboarac.BackColor = Color.FromArgb(250, 106, 87);
                textmiktar.BackColor = Color.FromArgb(250, 106, 87);
                textkadevsesizbirimfiyat.BackColor = Color.FromArgb(250, 106, 87);
               

                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into MUHASEBEFIS (TUR,CARI,PERSONEL,ARACPLAKA,MIKTAR,KDVSIZBIRIMFIYAT,TASIMAUCRET,ACIKLAMA,GENELTOPLAM,TARIH) values (@TUR,@CARI,@PERSONEL,@ARACPLAKA,@MIKTAR,@KDVSIZBIRIMFIYAT,@TASIMAUCRET,@ACIKLAMA,@GENELTOPLAM,@TARIH)", baglanti);
                komut.Parameters.AddWithValue("@TUR", combotur.Text);
                komut.Parameters.AddWithValue("@CARI", CARIID);
                komut.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                komut.Parameters.AddWithValue("@ARACPLAKA", ARACID);
                komut.Parameters.AddWithValue("@MIKTAR",float.Parse( textmiktar.Text));
                komut.Parameters.AddWithValue("@KDVSIZBIRIMFIYAT", textkadevsesizbirimfiyat.Text);
                komut.Parameters.AddWithValue("@ACIKLAMA", richTextaciklama.Text);
                komut.Parameters.AddWithValue("@TASIMAUCRET", texttasımaucret.Text);
                komut.Parameters.AddWithValue("@GENELTOPLAM", float.Parse(textgeneltoplam.Text));
                komut.Parameters.AddWithValue("@TARIH", dateTarih.Value);
                SqlDataReader dr = komut.ExecuteReader();
                MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                Sil();

            }

            goster();

        }
        private void Sil()
        {

            combotur.Text = "";
            combocari.Text = "";
            combopersonel.Text = "";
            comboarac.Text = "";
            textmiktar.Text = "";
            textkadevsesizbirimfiyat.Text = "";
            richTextaciklama.Text = "";
            texttasımaucret.Text = "";
            textgeneltoplam.Text = "";
        }
        private void texttasımafiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttoplamtutar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private void combokdv_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }


        public bool CheckInputIsNumber(string TheInput) {
             bool sonuc;
             double parsedValue;
             if (Double.TryParse(TheInput, out parsedValue))
             {

                 sonuc =  true;
             }
             else {
                 sonuc =  false;
             }

             return sonuc;


         }

     

        public void MuhFisHesaplama() {
           
            double miktar, birimfiyat, tasimaucret, toplamtutar;
            birimfiyat = Convert.ToDouble(CheckInputIsNumber(textkadevsesizbirimfiyat.Text) ? textkadevsesizbirimfiyat.Text : "0");
            miktar = Convert.ToDouble(CheckInputIsNumber(textmiktar.Text) ? textmiktar.Text : "0");
            tasimaucret = Convert.ToDouble(CheckInputIsNumber(texttasımaucret.Text) ? texttasımaucret.Text : "0");
            if (combotur.SelectedItem == "SATIS")
            {
                toplamtutar = (miktar * birimfiyat) - tasimaucret;
                textgeneltoplam.Text = toplamtutar.ToString();
            }
            if (combotur.SelectedItem == "ALIS")
            {
                toplamtutar = (miktar * birimfiyat);
                textgeneltoplam.Text = toplamtutar.ToString();
            }
            

        }

        private void textmiktar_TextChanged(object sender, EventArgs e)
        {
            float miktar = textmiktar.Text!=""? float.Parse(textmiktar.Text.ToString()):0;
            if (combotur.SelectedItem == "SATIS") {

                if (miktar > depostokdurumu) {
                    if (MessageBox.Show("Girilen Miktar Depoda Bulunmamaktadır! Devam Edilsin Mi?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        textmiktar.Text = "";
                    }
                    

                }
            }
        
            
        }

        private void textkdvlibirimfiyat_TextChanged(object sender, EventArgs e)
        {
        }

        private void textkadevsesizbirimfiyat_TextChanged(object sender, EventArgs e)
        {
            MuhFisHesaplama();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
         
        static void bekleme()
        {
            for (int i = 1; i < 100; i++)
            {
              
                System.Threading.Thread.Sleep(1000);
            }
           
        }
        
        public void DogrulamaClose(object sender, FormClosedEventArgs e) 
        {
            this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet3.MUHASEBEFIS);
        }
         

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                if (MessageBox.Show("KAYİT SİLMEYİ ONAYLAYIN?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    MUHASEBEID = row.Cells[0].Value.ToString();

                    dogrulama fr = new dogrulama();
                    fr.ID = MUHASEBEID;
                    fr.FormClosed += new FormClosedEventHandler(this.DogrulamaClose);

                    fr.Show();

                    Sil();
                 
                }
                else
{
                    MessageBox.Show("Kayıt işlemi tarafınızca iptal edilmiştir.", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");
            }

            goster();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

      

        private void combopersonel_SelectedValueChanged(object sender, EventArgs e)
        {
            PERSONELID = (combopersonel.SelectedItem as ComboboxItem).Value.ToString();
          
        }

        private void combopersonel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void combomuhasebe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combomuhasebe_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

   
        private void alismiktar()
        {
            
        }

        private void textmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

       
        private void textkadevsesizbirimfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

       
    

        private void texttasımaucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textgeneltoplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void combokdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void texttasımaucret_TextChanged(object sender, EventArgs e)
        {
            MuhFisHesaplama();
        }

        private void combotur_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MUHASEBEID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            combotur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            combocari.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combopersonel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboarac.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textmiktar.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textkadevsesizbirimfiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            texttasımaucret.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            richTextaciklama.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            textgeneltoplam.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dateTarih.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }
    }
}
