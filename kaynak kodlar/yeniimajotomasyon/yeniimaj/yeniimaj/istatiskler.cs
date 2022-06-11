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
    public partial class istatiskler : Form
    {
        public istatiskler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void istatiskler_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            depodurum frm = new depodurum();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personeldurum frm = new personeldurum();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracdurum FR = new aracdurum();
            FR.Show();
        }

        private void BTNGELİRİGDER_Click(object sender, EventArgs e)
        {
            gelirgidercs fr = new gelirgidercs();
            fr.Show();
        }
    }
}
