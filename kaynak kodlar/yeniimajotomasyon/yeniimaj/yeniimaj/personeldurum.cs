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
    public partial class personeldurum : Form
    {
        public personeldurum()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(Program.connection_string);

        private void personeldurum_Load(object sender, EventArgs e)
        {
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

           

            var dt1 = DateTime.Parse(date1.Value.ToString());
            var dt2 = DateTime.Parse(date2.Value.ToString());
    

            string query = " select MAX(PERSONEL.PERSONELADI + ' ' + PERSONEL.PERSONELSOYADI) as PERSONEL,SUM(MIKTAR) as MIKTAR " +
                "FROM MUHASEBEFIS" +
                " LEFT JOIN PERSONEL ON PERSONEL.PERSONELID=MUHASEBEFIS.PERSONEL " +
                " WHERE TARIH BETWEEN  '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "'  AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "' GROUP BY MUHASEBEFIS.PERSONEL ";  

            baglanti.Open();
            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                chart1.Series["PERSONEL"].Points.AddXY(DR[0].ToString(), DR[1].ToString());
            }
            baglanti.Close();
        }
    }
}
