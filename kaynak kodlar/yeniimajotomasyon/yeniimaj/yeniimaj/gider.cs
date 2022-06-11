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
    public partial class gider : Form
    {
        public string PERSONELID="";
        public string ARACID = "";
        public string TUR = "";
        public string CARIID = "";
        public string MUHASEBEID="";


        public gider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PERSONELID = (combopersonel.SelectedItem as ComboboxItem).Value.ToString();
           
        }

        private void gider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yeniimajservisDataSet6.MUHASEBEFIS' table. You can move, or remove it, as needed.
            this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet6.MUHASEBEFIS);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;



         

            comboarac.Items.Clear();
            combopersonel.Items.Clear();
            combotur.Items.Clear();
            combocari.Items.Clear();
            

           
          
            ComboboxItem itemTH = new ComboboxItem();
            itemTH.Text = "GIDER";
            itemTH.Value = "";
            combotur.Items.Add(itemTH);

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
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboarac_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARACID = (comboarac.SelectedItem as ComboboxItem).Value.ToString();   
        }

    
        private void combocari_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void combotur_SelectedValueChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand comut = new SqlCommand("select * from CARI WHERE TUR = '" + combotur.SelectedItem.ToString() + "'", baglanti);
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

        
         

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (combotur.Text == "" || combocari.Text==""|| textTUTAR.Text == "")
            {

                textTUTAR.BackColor = Color.FromArgb(250, 106, 87);
                combocari.BackColor = Color.FromArgb(250, 106, 87);
                combotur.BackColor = Color.FromArgb(250, 106, 87);
                MessageBox.Show("Kırmızı Rekli Alanları Boş Geçemezsiniz", "Boş Alan Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into MUHASEBEFIS (TUR,CARI,PERSONEL,ARACPLAKA,GENELTOPLAM,TARIH) values (@TUR,@CARI,@PERSONEL,@ARACPLAKA,@GENELTOPLAM,@TARIH)", baglanti);
                cmd.Parameters.AddWithValue("@TUR", combotur.Text);
                cmd.Parameters.AddWithValue("@CARI", CARIID);
                cmd.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                cmd.Parameters.AddWithValue("@ARACPLAKA", ARACID);
                cmd.Parameters.AddWithValue("@GENELTOPLAM", textTUTAR.Text);
                cmd.Parameters.AddWithValue("@TARIH", datetarih.Value);
                SqlDataReader dr2 = cmd.ExecuteReader();
                //this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet6.MUHASEBEFIS);
                MessageBox.Show("Kayıt Eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                Temizle();

            }



        }
        private void Temizle()
        {
           
            combotur.Text = "";
            combocari.Text = "";
            combopersonel.Text = "";
            comboarac.Text = "";
            textTUTAR.Text = "";
            return ; 
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnkaydet.Enabled = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MUHASEBEFIS set TUR=@TUR,CARI=@CARI,PERSONEL=@PERSONEL,ARACPLAKA=@ARACPLAKA,ACIKLAMA=@ACIKLAMA,GENELTOPLAM=@GENELTOPLAM,TARIH=@TARIH  WHERE MUHASEBEID=@MUHASEBEID", baglanti);
                komut.Parameters.AddWithValue("@TUR", combotur.Text);
                komut.Parameters.AddWithValue("@CARI", CARIID);
                komut.Parameters.AddWithValue("@PERSONEL", PERSONELID);
                komut.Parameters.AddWithValue("@ARACPLAKA", ARACID);
                komut.Parameters.AddWithValue("@GENELTOPLAM", float.Parse(textTUTAR.Text));
                komut.Parameters.AddWithValue("@ACIKLAMA",richaciklama.Text);
                komut.Parameters.AddWithValue("@TARIH", datetarih.Value);
                komut.Parameters.AddWithValue("@MUHASEBEID", MUHASEBEID);
                SqlDataReader dr = komut.ExecuteReader();
                this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet6.MUHASEBEFIS);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();


            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz!");
            }
            btnkaydet.Enabled = true;
            baglanti.Close();
          

        }
        public void DogrulamaClose(object sender, FormClosedEventArgs e)
        {
            
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
                    this.mUHASEBEFISTableAdapter.Fill(this.yeniimajservisDataSet6.MUHASEBEFIS);
                    MessageBox.Show("Kayıt başarılı bir şekilde silindi!");
                    Temizle();
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void combocari_SelectedValueChanged(object sender, EventArgs e)
        {
          
            CARIID = (combocari.SelectedItem as ComboboxItem).Value.ToString(); 
        }

       
        private void combotur_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            MUHASEBEID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            combotur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            combocari.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            combopersonel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboarac.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textTUTAR.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            datetarih.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            richaciklama.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
          
           // datetarih.Value = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }
    }
    }

