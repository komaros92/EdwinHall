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
        BazaDanych baza;
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

        public void zPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.baza = new BazaDanych();
            this.baza.Wczytaj();
            dataGridView1.DataSource = baza.dsAccess.Tables[0];
            //dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void odświeżWykresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            chart1.DataSource = baza.dsAccess;
            chart1.DataBind();
            chart1.Series["Tabela1"].XValueMember = "Temp";
            chart1.Series["Tabela1"].YValueMembers = "Konc"; 
            chart1.DataSource = baza.dsAccess;
            chart1.DataBind();
            chart1.Series["Tabela1"].XValueMember = "Temp";
            chart1.Series["Tabela1"].YValueMembers = "Konc";  
        }


    }
}
