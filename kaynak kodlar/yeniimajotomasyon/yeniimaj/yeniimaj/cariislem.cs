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
    public partial class cariislem : Form
    {

        public string CARIID;
        public int SATIS =0;
        public int ALIS =1;
        public cariislem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void button1_Click(object sender, EventArgs e)
        {
            if(combotür.Text=="ALIS" || combotür.Text == "SATIS")
            {
                if (combotür.SelectedItem == "" || textunvan.Text == "" || textil.Text == "" || textilce.Text == "" || texttelefon.Text == "")
                {

                    combotür.BackColor = Color.FromArgb(250, 106, 87);
                    textunvan.BackColor = Color.FromArgb(250, 106, 87);
                    textil.BackColor = Color.FromArgb(250, 106, 87);
                    textilce.BackColor = Color.FromArgb(250, 106, 87);
                    texttelefon.BackColor = Color.FromArgb(250, 106, 87);
                    MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into CARI (TUR,UNVAN,IL,ILCE,ADRES,VERGINO,TELEFON,EMAIL) values (@TUR,@UNVAN,@IL,@ILCE,@ADRES,@VERGINO,@TELEFON,@EMAIL)", baglanti);
                    komut.Parameters.AddWithValue("@TUR", combotür.Text);
                    komut.Parameters.AddWithValue("@UNVAN", textunvan.Text);
                    komut.Parameters.AddWithValue("@IL", textil.Text);
                    komut.Parameters.AddWithValue("@ILCE", textilce.Text);
                    komut.Parameters.AddWithValue("@ADRES", textadres.Text);
                    komut.Parameters.AddWithValue("@VERGINO", textvergino.Text);
                    komut.Parameters.AddWithValue("@TELEFON", texttelefon.Text);
                    komut.Parameters.AddWithValue("@EMAIL", textemail.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    this.cARITableAdapter.Fill(this.yeniimajservisDataSet2.CARI);
                    MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();

                    Sil();

                }
            }
            else
            {
                if (textunvan.Text == "")
                {
                    textunvan.BackColor = Color.FromArgb(250, 106, 87);
                    MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into CARI (TUR,UNVAN,IL,ILCE,ADRES,VERGINO,TELEFON,EMAIL) values (@TUR,@UNVAN,@IL,@ILCE,@ADRES,@VERGINO,@TELEFON,@EMAIL)", baglanti);
                    komut.Parameters.AddWithValue("@TUR", combotür.Text);
                    komut.Parameters.AddWithValue("@UNVAN", textunvan.Text);
                    komut.Parameters.AddWithValue("@IL", textil.Text);
                    komut.Parameters.AddWithValue("@ILCE", textilce.Text);
                    komut.Parameters.AddWithValue("@ADRES", textadres.Text);
                    komut.Parameters.AddWithValue("@VERGINO", textvergino.Text);
                    komut.Parameters.AddWithValue("@TELEFON", texttelefon.Text);
                    komut.Parameters.AddWithValue("@EMAIL", textemail.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    this.cARITableAdapter.Fill(this.yeniimajservisDataSet2.CARI);
                    MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();

                    Sil();
                }
              
            }
           

            
        }
        private void Sil()
        {
            combotür.Text = "";
            textunvan.Text = "";
            textil.Text = "";
            textilce.Text = "";
            textadres.Text = "";
            textvergino.Text = "";
            texttelefon.Text = "";
            textemail.Text = "";

            return;
        }
        private void cariislem_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            // TODO: This line of code loads data into the 'yeniimajservisDataSet2.CARI' table. You can move, or remove it, as needed.
            this.cARITableAdapter.Fill(this.yeniimajservisDataSet2.CARI);

            ComboboxItem itemTH = new ComboboxItem();
            itemTH.Text = "GIDER";
            itemTH.Value = "";
            combotür.Items.Add(itemTH);

        }

        private void BTNguncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
               
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update CARI set TUR=@TUR, UNVAN=@UNVAN,IL=@IL,ILCE=@ILCE,ADRES=@ADRES,VERGINO=@VERGINO,TELEFON=@TELEFON,EMAIL=@EMAIL  WHERE CARIID=@CARIID", baglanti);
                komut.Parameters.AddWithValue("@TUR", combotür.Text);
                komut.Parameters.AddWithValue("@UNVAN", textunvan.Text);
                komut.Parameters.AddWithValue("@IL", textil.Text);
                komut.Parameters.AddWithValue("@ILCE", textilce.Text);
                komut.Parameters.AddWithValue("@ADRES", textadres.Text);
                komut.Parameters.AddWithValue("@VERGINO", textvergino.Text);
                komut.Parameters.AddWithValue("@TELEFON", texttelefon.Text);
                komut.Parameters.AddWithValue("@EMAIL", textemail.Text);
                komut.Parameters.AddWithValue("@CARIID", CARIID);
                SqlDataReader dr = komut.ExecuteReader();
                this.cARITableAdapter.Fill(this.yeniimajservisDataSet2.CARI);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sil();

            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");
            }
           
          
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            CARIID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            combotür.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textunvan.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textil.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textilce.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textvergino.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            texttelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            textemail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textadres.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bool checkCari = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("KAYİT SİLMEYİ ONAYLAYIN?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    CARIID = row.Cells[0].Value.ToString();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("select count(*) as SAYI FROM MUHASEBE  WHERE CARI=@CARIID", baglanti);
                    komut1.Parameters.AddWithValue("@CARIID", CARIID);
                    SqlDataReader dr = komut1.ExecuteReader();
                    while (dr.Read())
                    {
                        if (float.Parse(dr[0].ToString()) > 0)
                        {
                            checkCari = false;
                        }
                    }

                    dr.Close();
                    if (checkCari) { 
                        SqlCommand komut = new SqlCommand("delete CARI  WHERE CARIID=@CARIID", baglanti);
                        komut.Parameters.AddWithValue("@CARIID", CARIID);
                        SqlDataReader dr2 = komut.ExecuteReader();
                        this.cARITableAdapter.Fill(this.yeniimajservisDataSet2.CARI);
                        MessageBox.Show("Kayıt SİLİNDİ", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Muhasebe fişi oluşturulmuş carilerde silme işlemi yapılamaz.", "Silme İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


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
            Sil();
            baglanti.Close();
            
        }

        private void btncık_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textvergino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void texttelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }
    }
}
