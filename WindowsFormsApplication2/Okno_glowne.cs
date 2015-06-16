using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace EdwinHall
{
    public partial class EdwinHallC : Form
    {
        Ustawienia ustawienia = new Ustawienia();

        public EdwinHallC()
        {
            InitializeComponent();
            
        }

        private void ToolStripMenuItem_Pomiar_Nowy_Click(object sender, EventArgs e)
        {

        }

        private void ustawieniaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ustawienia.ShowDialog();
        }
    }
}
