using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Ustawienia : Form
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        public string Adres_V = "";
        public string Adres_A = "";
        public string Adres_Z = "";
        public string Adres_uC = "";
        public int delay = 250;

        string[] porty;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString() + " ms";
        }

        private void Ustawienia_Load(object sender, EventArgs e)
        {
            this.porty = System.IO.Ports.SerialPort.GetPortNames();
            textBox1.Text = this.Adres_V;
            textBox2.Text = this.Adres_A;
            textBox3.Text = this.Adres_Z;
            comboBox1.Text = this.Adres_uC;

        }

        private void Ustawienia_Closing(object sender, CancelEventArgs e)
        {
            textBox1.Text = this.Adres_V;
            textBox2.Text = this.Adres_A;
            textBox3.Text = this.Adres_Z;
            comboBox1.Text = this.Adres_uC;
        }
 
    }
}


