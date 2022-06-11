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
    public partial class gelirkayit : Form
    {
        public string PERSONELID = ""; 
        public string TUR = "";
        public string CARIID = "";
        public string MUHASEBEID = "";
        public string ARACID = "";



        public gelirkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void gelirkayit_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from PERSONEL", baglanti);
            SqlDataReader DR3 = komut3.ExecuteReader();
            while (DR3.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = DR3[1].ToString();
                item.Value = DR3[0].ToString();
                combopersonel.Items.Add(item);

            }
            baglanti.Close();

            // TODO: This line of code loads data into the 'yeniimajservisDataSet8.MUHASEBEFIS' table. You can move, or remove it, as needed.

            this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet8.MUHASEBEFIS);

            ComboboxItem itemTH = new ComboboxItem();
            itemTH.Text = "ODEME";
            itemTH.Value = "ODEME";
            combotur.Items.Add(itemTH);
            
        }

        private void combocari_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void combotur_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void combotur_SelectedValueChanged(object sender, EventArgs e)
        {
            combocari.Items.Clear();
            if (combotur.Text == "ODEME")
            {
                baglanti.Open();
                // SqlCommand comut = new SqlCommand("select * from CARI WHERE TUR = '" + combotur.SelectedItem.ToString() + "'", baglanti);
                SqlCommand comut = new SqlCommand("select * from CARI WHERE TUR='ALIS' OR TUR='SATIS'", baglanti);
                SqlDataReader DRR = comut.ExecuteReader();
                while (DRR.Read())
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = DRR[2].ToString();
                    item.Value = DRR[0].ToString();
                    combocari.Items.Add(item);

                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜR SEÇİNİZ", "UYARI MESAJI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void combotur_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (combotur.Text == "" || combocari.Text == "" || textTUTAR.Text == "")
            {

                textTUTAR.BackColor = Color.FromArgb(250, 106, 87);
                combocari.BackColor = Color.FromArgb(250, 106, 87);
                combotur.BackColor = Color.FromArgb(250, 106, 87);
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into MUHASEBEFIS (TUR,CARI,PERSONEL,GENELTOPLAM,TARIH) values (@TUR,@CARI,@PERSONEL,@GENELTOPLAM,@TARIH)", baglanti);
                cmd.Parameters.AddWithValue("@TUR", combotur.Text);
                cmd.Parameters.AddWithValue("@CARI", CARIID);
                cmd.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                cmd.Parameters.AddWithValue("@GENELTOPLAM", textTUTAR.Text);
                cmd.Parameters.AddWithValue("@TARIH", datetarih.Value);
                SqlDataReader dr2 = cmd.ExecuteReader();
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet8.MUHASEBEFIS);
                MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
             

            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnkaydet.Enabled = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MUHASEBEFIS set TUR=@TUR,CARI=@CARI,PERSONEL=@PERSONEL,ACIKLAMA=@ACIKLAMA,GENELTOPLAM=@GENELTOPLAM,TARIH=@TARIH  WHERE MUHASEBEID=@MUHASEBEID", baglanti);
                komut.Parameters.AddWithValue("@TUR", combotur.Text);
                komut.Parameters.AddWithValue("@CARI", CARIID);
                komut.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                komut.Parameters.AddWithValue("@GENELTOPLAM", float.Parse(textTUTAR.Text));
                komut.Parameters.AddWithValue("@ACIKLAMA", richaciklama.Text);
                komut.Parameters.AddWithValue("@TARIH", datetarih.Value);
                komut.Parameters.AddWithValue("@MUHASEBEID", MUHASEBEID);
                SqlDataReader dr = komut.ExecuteReader();
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet8.MUHASEBEFIS);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek istediğiniz satırı seçiniz!");
            }
           
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MUHASEBEID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            combotur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            combocari.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combopersonel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textTUTAR.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            datetarih.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            richaciklama.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString(); 
         
      
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("KAYİT SİLMEYİ ONAYLAYIN?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                    MUHASEBEID = row.Cells[0].Value.ToString();
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete MUHASEBEFIS  WHERE MUHASEBEID=@MUHASEBEID", baglanti);
                    komut.Parameters.AddWithValue("@MUHASEBEID", MUHASEBEID);
                    SqlDataReader dr = komut.ExecuteReader();
                    this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet8.MUHASEBEFIS);
                    MessageBox.Show("Kayıt başarılı bir şekilde silindi!");
                  
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
    }
}
