using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEHER_Yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        struct seher
        {
            public string cityname;
            public int citynum;
            public string cityfam;
            public string cityteam;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seher s = new seher();
            s.cityname = textBox1.Text;
            s.citynum = Convert.ToInt16(textBox2.Text);
            s.cityfam = textBox3.Text;
            s.cityteam = textBox4.Text;
            MessageBox.Show("CITY NAME "  +s.cityname + "\n"+ "CITY NUMBER " +s.citynum + "\n"+ "CITY FAMOUS" + s.cityfam + "\n"+ "CITY TEAM" + s.cityteam);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
