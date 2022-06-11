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
    public partial class arac : Form
    {
        public Boolean checkGuncelle = false;
        public arac()
        {
            InitializeComponent();
        }
        public string ARACID;
        SqlConnection baglanti = new SqlConnection(Program.connection_string);

        private void arac_Load(object sender, EventArgs e)
        {
             dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
            
            // TODO: This line of code loads data into the 'yeniimajservisDataSet.ARAC' table. You can move, or remove it, as needed.
            this.aRACTableAdapter.Fill(this.yeniimajservisDataSet.ARAC);

           

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if(textplaka.Text=="")
            {
                textplaka.BackColor = Color.FromArgb(250, 106, 87);
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into ARAC (PLAKA,KAPASİTE) values (@PLAKA,@KAPASİTE)", baglanti);
                komut.Parameters.AddWithValue("@PLAKA", textplaka.Text);
                komut.Parameters.AddWithValue("@KAPASİTE", textkapasite.Text);
                SqlDataReader dr = komut.ExecuteReader();
                this.aRACTableAdapter.Fill(this.yeniimajservisDataSet.ARAC);
                MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                textplaka.Text = "";
                textkapasite.Text = "";
            }

            baglanti.Close();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update ARAC set PLAKA=@PLAKA, KAPASİTE=@KAPASİTE  WHERE ARACID=@ARACID", baglanti);
                komut.Parameters.AddWithValue("@PLAKA", textplaka.Text);
                komut.Parameters.AddWithValue("@KAPASİTE", textkapasite.Text);
                komut.Parameters.AddWithValue("@ARACID", ARACID);
                SqlDataReader dr = komut.ExecuteReader();
                this.aRACTableAdapter.Fill(this.yeniimajservisDataSet.ARAC);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");

            }
            

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ARACID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textplaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textkapasite.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

           
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            bool checkarac = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("KAYİT SİLMEYİ ONAYLAYIN?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    ARACID = row.Cells[0].Value.ToString();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("select count(*) as SAYI FROM MUHASEBEFIS  WHERE ARACPLAKA=@ARACID", baglanti);
                    komut1.Parameters.AddWithValue("@ARACID", ARACID);
                    SqlDataReader dr = komut1.ExecuteReader();
                    while (dr.Read())
                    {
                        if (float.Parse(dr[0].ToString()) > 0)
                        {
                            checkarac = false;
                        }
                    }

                    dr.Close();
                    if (checkarac)
                    {

                        SqlCommand komut = new SqlCommand("delete ARAC  WHERE ARACID=@ARACID", baglanti);
                        this.aRACTableAdapter.Fill(this.yeniimajservisDataSet.ARAC);
                        komut.Parameters.AddWithValue("@ARACID", ARACID);
                        SqlDataReader dr2 = komut.ExecuteReader();

                        MessageBox.Show("Kayıt SİLİNDİ", "Kayıt İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Muhasebe fişi oluşturulmuş araclarda silme işlemi yapıamaz.", "Silme İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textplaka_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textkapasite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void textplaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
