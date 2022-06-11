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
    public partial class depodurum : Form
    {
        public depodurum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);

        private void depodurum_Load(object sender, EventArgs e)
        {
            float alis, satis, capasite, durum;
            alis = 0;
            satis = 0;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT ISNULL(SUM( MIKTAR),0) AS GT FROM MUHASEBEFIS WHERE TUR='ALIS'", baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {

                
                alis = float.Parse(DR[0].ToString());

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT ISNULL(SUM( MIKTAR),0) AS GT FROM MUHASEBEFIS WHERE TUR='SATIS'", baglanti);
            SqlDataReader DR2 = komut2.ExecuteReader();
            while (DR2.Read())
            {

                
                satis = float.Parse(DR2[0].ToString());

            }
            baglanti.Close();


           


            durum = alis - satis;
            labelkalan.Text = durum.ToString() + " TON";
            capasite = 300;

            
            float pd1, pd2;
            pd1 = (durum / capasite) * 360;
            pd2 = ((capasite - durum) / capasite) * 360;


            Pen p = new Pen(Color.FromArgb(214, 124, 79), 3);

            Graphics g = this.CreateGraphics();
            Rectangle rec = new Rectangle(label6.Location.X + label6.Size.Width + -90, 40, 339, 339);

            Brush b1 = new SolidBrush(Color.FromArgb(92, 198, 219));
            Brush b2 = new SolidBrush(Color.FromArgb(152, 153, 155));


            g.Clear(depodurum.DefaultBackColor);
            g.DrawPie(p, rec, 0, pd1);
            g.FillPie(b1, rec, 0, pd1);

            g.DrawPie(p, rec, pd1, pd2);
            g.FillPie(b2, rec, pd1, pd2);

        }

        private void labelkalan_Click(object sender, EventArgs e)
        {

        }
    }
}
