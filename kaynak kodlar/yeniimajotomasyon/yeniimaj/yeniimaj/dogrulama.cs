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
    public partial class dogrulama : Form
    {
        public string ID;

        public Boolean datamuhasebe;
        public dogrulama()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void button1_Click(object sender, EventArgs e)
        {

    
            bool checksiftre = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * From YONETICI where  SIFRE=@SIFRE", baglanti);
            komut.Parameters.AddWithValue("@SIFRE", textdogrulama.Text);
            using (SqlDataReader reader = komut.ExecuteReader())
            {
                if (reader.Read())
                {
                    checksiftre = true;
                    
                   
                }
                else
                {
                    checksiftre = false;
                }

            }

            baglanti.Close();

            if (checksiftre)
            {
               
                baglanti.Open();
                SqlCommand kMt = new SqlCommand("delete MUHASEBEFIS  WHERE MUHASEBEID="+this.ID, baglanti);
                SqlDataReader dr3 = kMt.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("kayıt slindi");
                this.Close();
            }
            else {
                MessageBox.Show("ŞİFRE HATALI !", "Bilgi mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void dogrulama_Load(object sender, EventArgs e)
        {

        }
    }
}
