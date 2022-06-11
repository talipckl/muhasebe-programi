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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Program.connection_string);


        private void button1_Click(object sender, EventArgs e)
        {

            graifkler();
            cariislem fr = new cariislem();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muhasebefisi fr = new muhasebefisi();
            fr.Show();

            graifkler();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel frm = new personel();
            frm.Show();

            graifkler();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arac fr = new arac();
            fr.Show();

            graifkler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            depo fr = new depo();
            fr.Show();

            graifkler();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            istatiskler fr = new istatiskler();
            fr.Show();


            graifkler();

        }

        private void BTNGELİRİGDER_Click(object sender, EventArgs e)
        {
            gider fr = new gider();
            fr.Show();

            graifkler();
        }
        private void tabloyutemizle()
        {

            graifkler();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        
        }


        private void menu_Load(object sender, EventArgs e)
        {
           

            graifkler();

        }
        private void graifkler()
        {
            chart1.Series["ALIS"].Color = Color.FromArgb(91, 194, 213);
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            // chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            var dt2 = DateTime.Now;
            var dt1 = DateTime.Now.AddDays(-7);

            string query = "select " +
                  "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) as GELIR, " +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as GIDER, " +
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) -" +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as KAR" +
                "  from MUHASEBEFIS MF" +
                "  left  join CARI C on C.CARIID = MF.CARI" +
                " WHERE MF.TARIH BETWEEN '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "' AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "' ";


            baglanti.Open();
            SqlCommand theQuery = new SqlCommand(query, baglanti);
            SqlDataReader dr = theQuery.ExecuteReader();

            while (dr.Read())
            {


                labelkar.Text = dr[2].ToString() + " TL";

            }

            
            baglanti.Close();

            string query2 = "select " +
                "  MF.TARIH, " +
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) as GELIR, " +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as GIDER, " +
                "  SUM(case when C.TUR = 'SATIS' AND  MF.TUR = 'ODEME' THEN GENELTOPLAM ELSE 0 end) -" +
                "  SUM(case when C.TUR IN('ALIS', 'GIDER') AND MF.TUR IN('GIDER', 'ODEME') THEN GENELTOPLAM ELSE 0 end) as KAR" +
                "  from MUHASEBEFIS MF" +
                "  left join CARI C on C.CARIID = MF.CARI" +
                "  WHERE MF.TARIH BETWEEN '" + dt1.Year + "-" + dt1.Month + "-" + dt1.Day + "' AND '" + dt2.Year + "-" + dt2.Month + "-" + dt2.Day + "' " +
                "  GROUP BY MF.TARIH ORDER BY Mf.TARIH";

            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand(query2, baglanti);
            SqlDataReader drr = cmd1.ExecuteReader();
            while (drr.Read())
            {
                var theDate = DateTime.Parse(drr[0].ToString());
                var gun = this.GUNLER(theDate.DayOfWeek.ToString());
                chart1.Series["ALIS"].Points.AddXY(gun, drr[2]);

            }

            baglanti.Close();
        }
        public string GUNLER(String gun)
        {

            switch (gun)
            {
                case "Monday":
                    return "PAZARTESİ";
                    break;

                case "Tuesday":
                    return "SALI";
                    break;
                case "Wednesday":
                    return "ÇARŞAMBA";
                    break;
                case "Thursday":
                    return "PERŞEMBE";
                    break;
                case "Friday":
                    return "CUMA";
                    break;
                case "Saturday":
                    return "CUMARTESİ";
                    break;
                case "Sunday":
                    return "PAZAR";
                    break;
                default:
                    return "";
                    break;


            }
        }

        private void labelkar_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            gelirkayit FR = new gelirkayit();
            FR.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cariborc fr = new cariborc();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            personelmaas fr = new personelmaas();
            fr.Show();
        }
    }
}
