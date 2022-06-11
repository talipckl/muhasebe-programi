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
    public partial class gelirgidercs : Form
    {
        public gelirgidercs()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection(Program.connection_string);
        private void gelirgidercs_Load(object sender, EventArgs e)
        {
            
            chart2.Series["GİDER"].Color = Color.Red;
            chart2.Series["GELİR"].Color = Color.Blue;
            chart2.Series["KAR"].Color = Color.Green;


            string query =" select"+
                "  MONTH(TARIH) as TARIH, "+
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) as GELIR, "+
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as GIDER, "+
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) -"+
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as KAR"+
                "  from MUHASEBEFIS MF"+
                "  left"+
                "  join CARI C on C.CARIID = MF.CARI" +
                "  WHERE YEAR(MF.TARIH) = YEAR(GETDATE())" +
                "  GROUP BY MONTH(TARIH),MF.TUR ORDER BY MONTH(TARIH)";

            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand(query, baglanti);
            SqlDataReader drr = cmd1.ExecuteReader();
            while (drr.Read())
            {
                var ay = this.Aylar(int.Parse(drr[0].ToString()));
                chart2.Series["GİDER"].Points.AddXY(ay, drr[2]);
                chart2.Series["GELİR"].Points.AddXY(ay, drr[1]);
                chart2.Series["KAR"].Points.AddXY(ay, drr[3]);
                // chart2.Series["ORNEK"].Points.AddXY(drr[1]).ToString(), drr[0].ToString();
            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

           foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            var dt1 = DateTime.Parse(date1.Value.ToString());
            var dt2 = DateTime.Parse(date2.Value.ToString());
          
            string query = " select" +
                "  MONTH(TARIH) as TARIH, " +
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) as GELIR, " +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as GIDER, " +
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) -" +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as KAR" +
                "  from MUHASEBEFIS MF" +
                "  left" +
                "  join CARI C on C.CARIID = MF.CARI" +
                "  WHERE MF.TARIH BETWEEN '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "' AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "' "+
                " GROUP BY MONTH(MF.TARIH)";
           
            
            baglanti.Open();
            SqlCommand theQuery = new SqlCommand(query, baglanti);
            SqlDataReader dr = theQuery.ExecuteReader();

            while (dr.Read())
            {

                labelgelir.Text = dr[0].ToString() + "  TL";
                labelgider.Text = dr[1].ToString()+ "  TL";
                labelkar.Text = dr[2].ToString() + " TL";

            }
          

            baglanti.Close();

            

            baglanti.Open();
            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                chart1.Series["GELIR"].Points.AddXY(DR[0].ToString(), DR[0].ToString());
                chart1.Series["GIDER"].Points.AddXY(DR[1].ToString(), DR[1].ToString());
                chart1.Series["KAR"].Points.AddXY(DR[2].ToString(), DR[2].ToString());
            }
            baglanti.Close();


          
        }

        public string Aylar(int ay) {

            switch (ay)
            {
                case 1:
                    return "OCAK";
                    break;

                case 2:
                    return "ŞUBAT";
                    break;
                case 3:
                    return "MART";
                    break;
                case 4:
                    return "NİSAN";
                    break;
                case 5:
                    return "MAYIS";
                    break;
                case 6:
                    return "HAZİRAN";
                    break;
                case 7:
                    return "TEMMUZ";
                    break;
                case 8:
                    return "AĞUSTOS";
                    break;
                case 9:
                    return "EYLÜL";
                    break;
                case 10:
                    return "EKİM";
                    break;
                case 11:
                    return "KASIM";
                    break;
                case 12:
                    return "ARALIK";
                    break;

                default:
                    return "";
                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
