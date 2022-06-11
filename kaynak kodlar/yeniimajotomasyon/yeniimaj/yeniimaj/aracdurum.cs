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
    public partial class aracdurum : Form
    {
        public aracdurum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void aracdurum_Load(object sender, EventArgs e)
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
           

          
            string query = " select MAX(ARAC.PLAKA ) as ARAC,SUM(MIKTAR) as MIKTAR " +
                "FROM MUHASEBEFIS " +
                " LEFT JOIN ARAC ON ARAC.ARACID=MUHASEBEFIS.ARACPLAKA " +
                " WHERE MUHASEBEFIS.TUR='ALIS' AND TARIH BETWEEN  '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "'  AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "' GROUP BY MUHASEBEFIS.ARACPLAKA ";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                chart1.Series["ARAC"].Points.AddXY(DR[0].ToString(), DR[1].ToString());
            }
            baglanti.Close();
        }
    }
    }

