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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * From YONETICI where KULLANICIADI=@KULLANICIADI and SIFRE=@SIFRE", baglanti);
            komut.Parameters.AddWithValue("@KULLANICIADI", textkullanici.Text);
            komut.Parameters.AddWithValue("@SIFRE", textsifre.Text);
            using (SqlDataReader reader = komut.ExecuteReader())
            {
                if (reader.Read())
                {
                    menu fr = new menu();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("KULLANICIADI VEYA ŞİFRE HATALI !", "Bilgi mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            baglanti.Close();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
