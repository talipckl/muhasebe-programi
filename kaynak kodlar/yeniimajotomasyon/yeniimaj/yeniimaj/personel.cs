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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        public string PERSONELID;
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personel_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            // TODO: This line of code loads data into the 'yeniimajservisDataSet1.PERSONEL' table. You can move, or remove it, as needed.
            this.pERSONELTableAdapter.Fill(this.yeniimajservisDataSet1.PERSONEL);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(textadi.Text=="" || textsoyadi.Text == "" || textil.Text == "" || textmaas.Text == "" || texttelefon.Text == "")
            {
                
                textadi.BackColor = Color.FromArgb(250, 106, 87);
                textsoyadi.BackColor = Color.FromArgb(250, 106, 87);
                textil.BackColor = Color.FromArgb(250, 106, 87);
                textmaas.BackColor = Color.FromArgb(250, 106, 87);
                texttelefon.BackColor = Color.FromArgb(250, 106, 87);
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into PERSONEL (PERSONELADI,PERSONELSOYADI,IL,ILCE,ADRES,MAAS,TELEFON,EMAIL) values (@PERSONELADI,@PERSONELSOYADI,@IL,@ILCE,@ADRES,@MAAS,@TELEFON,@EMAIL)", baglanti);
                komut.Parameters.AddWithValue("@PERSONELADI", textadi.Text);
                komut.Parameters.AddWithValue("@PERSONELSOYADI", textsoyadi.Text);
                komut.Parameters.AddWithValue("@IL", textil.Text);
                komut.Parameters.AddWithValue("@ILCE", textilce.Text);
                komut.Parameters.AddWithValue("@ADRES", textadres.Text);
                komut.Parameters.AddWithValue("@MAAS", textmaas.Text);
                komut.Parameters.AddWithValue("@TELEFON", texttelefon.Text);
                komut.Parameters.AddWithValue("@EMAIL", textemail.Text);
                SqlDataReader dr = komut.ExecuteReader();
                this.pERSONELTableAdapter.Fill(this.yeniimajservisDataSet1.PERSONEL);
                MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
           

            textadi.Text = "";
            textsoyadi.Text = "";
            textil.Text = "";
            textilce.Text = "";
            textadres.Text = "";
            textmaas.Text = "";
            texttelefon.Text = "";
            textemail.Text = "";


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update PERSONEL set PERSONELADI=@PERSONELADI, PERSONELSOYADI=@PERSONELSOYADI,IL=@IL,ILCE=@ILCE,ADRES=@ADRES,MAAS=@MAAS,TELEFON=@TELEFON,EMAIL=@EMAIL  WHERE PERSONELID=@PERSONELID", baglanti);
                komut.Parameters.AddWithValue("@PERSONELADI", textadi.Text);
                komut.Parameters.AddWithValue("@PERSONELSOYADI", textsoyadi.Text);
                komut.Parameters.AddWithValue("@IL", textil.Text);
                komut.Parameters.AddWithValue("@ILCE", textilce.Text);
                komut.Parameters.AddWithValue("@ADRES", textadres.Text);
                komut.Parameters.AddWithValue("@MAAS", textmaas.Text);
                komut.Parameters.AddWithValue("@TELEFON", texttelefon.Text);
                komut.Parameters.AddWithValue("@EMAIL", textemail.Text);
                komut.Parameters.AddWithValue("@PERSONELID", PERSONELID);
                SqlDataReader dr = komut.ExecuteReader();
                this.pERSONELTableAdapter.Fill(this.yeniimajservisDataSet1.PERSONEL);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");
            }
            baglanti.Close();
            textadi.Text = "";
            textsoyadi.Text = "";
            textil.Text = "";
            textilce.Text = "";
            textadres.Text = "";
            textmaas.Text = "";
            texttelefon.Text = "";
            textemail.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bool checkpersonel = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("KAYİT SİLMEYİ ONAYLAYIN?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    PERSONELID = row.Cells[0].Value.ToString();
                    baglanti.Open();

                    SqlCommand komut1 = new SqlCommand("select count(*) as SAYI FROM MUHASEBEFIS WHERE PERSONEL=@PERSONELID", baglanti);
                    komut1.Parameters.AddWithValue("@PERSONELID", PERSONELID);
                    SqlDataReader dr = komut1.ExecuteReader();
                    while (dr.Read())
                    {
                        if (float.Parse(dr[0].ToString()) > 0)
                        {
                            checkpersonel = false;
                        }
                    }

                    dr.Close();
                    if (checkpersonel)
                    {
                        SqlCommand komut = new SqlCommand("delete PERSONEL  WHERE PERSONELID=@PERSONELID", baglanti);
                        this.pERSONELTableAdapter.Fill(this.yeniimajservisDataSet1.PERSONEL);
                        komut.Parameters.AddWithValue("@PERSONELID", PERSONELID);
                        SqlDataReader dr2 = komut.ExecuteReader();

                       

                        MessageBox.Show("Kayıt SİLİNDİ", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Muhasebe fişi oluşturulmuş araclarda silme işlemi yapılamaz.", "Silme İptal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            baglanti.Close();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            PERSONELID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textadi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textil.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textilce.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textadres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textmaas.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            texttelefon.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textemail.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void textmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void texttelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
