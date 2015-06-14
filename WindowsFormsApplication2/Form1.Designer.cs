namespace EdwinHall
{
    partial class EdwinHallC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_WskazBaze = new System.Windows.Forms.ToolStripMenuItem();
            this.zPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naSerwerzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EksportujDane = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EksportujWykres = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EksportujTabele = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Pomiar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Pomiar_Nowy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Widok = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.odświeżWykresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_Menu,
            this.ToolStripMenuItem_Pomiar,
            this.ToolStripMenuItem_Widok});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(742, 23);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripComboBox_Menu
            // 
            this.toolStripComboBox_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripComboBox_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_WskazBaze,
            this.ToolStripMenuItem_EksportujDane,
            this.toolStripSeparator1,
            this.ustawieniaToolStripMenuItem});
            this.toolStripComboBox_Menu.Name = "toolStripComboBox_Menu";
            this.toolStripComboBox_Menu.Size = new System.Drawing.Size(50, 19);
            this.toolStripComboBox_Menu.Text = "Menu";
            // 
            // ToolStripMenuItem_WskazBaze
            // 
            this.ToolStripMenuItem_WskazBaze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zPlikuToolStripMenuItem,
            this.naSerwerzeToolStripMenuItem});
            this.ToolStripMenuItem_WskazBaze.Name = "ToolStripMenuItem_WskazBaze";
            this.ToolStripMenuItem_WskazBaze.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_WskazBaze.Text = "Wskaż bazę";
            // 
            // zPlikuToolStripMenuItem
            // 
            this.zPlikuToolStripMenuItem.Name = "zPlikuToolStripMenuItem";
            this.zPlikuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zPlikuToolStripMenuItem.Text = "Baza lokalna...";
            this.zPlikuToolStripMenuItem.Click += new System.EventHandler(this.zPlikuToolStripMenuItem_Click);
            // 
            // naSerwerzeToolStripMenuItem
            // 
            this.naSerwerzeToolStripMenuItem.Name = "naSerwerzeToolStripMenuItem";
            this.naSerwerzeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.naSerwerzeToolStripMenuItem.Text = "Na serwerze...";
            this.naSerwerzeToolStripMenuItem.Visible = false;
            // 
            // ToolStripMenuItem_EksportujDane
            // 
            this.ToolStripMenuItem_EksportujDane.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EksportujWykres,
            this.ToolStripMenuItem_EksportujTabele});
            this.ToolStripMenuItem_EksportujDane.Name = "ToolStripMenuItem_EksportujDane";
            this.ToolStripMenuItem_EksportujDane.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_EksportujDane.Text = "Eksportuj dane";
            // 
            // ToolStripMenuItem_EksportujWykres
            // 
            this.ToolStripMenuItem_EksportujWykres.Name = "ToolStripMenuItem_EksportujWykres";
            this.ToolStripMenuItem_EksportujWykres.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_EksportujWykres.Text = "Wykres";
            // 
            // ToolStripMenuItem_EksportujTabele
            // 
            this.ToolStripMenuItem_EksportujTabele.Name = "ToolStripMenuItem_EksportujTabele";
            this.ToolStripMenuItem_EksportujTabele.Size = new System.Drawing.Size(112, 22);
            this.ToolStripMenuItem_EksportujTabele.Text = "Tabela";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia...";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click_1);
            // 
            // ToolStripMenuItem_Pomiar
            // 
            this.ToolStripMenuItem_Pomiar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Pomiar_Nowy,
            this.toolStripSeparator2});
            this.ToolStripMenuItem_Pomiar.Name = "ToolStripMenuItem_Pomiar";
            this.ToolStripMenuItem_Pomiar.Size = new System.Drawing.Size(57, 19);
            this.ToolStripMenuItem_Pomiar.Text = "Pomiar";
            // 
            // ToolStripMenuItem_Pomiar_Nowy
            // 
            this.ToolStripMenuItem_Pomiar_Nowy.Name = "ToolStripMenuItem_Pomiar_Nowy";
            this.ToolStripMenuItem_Pomiar_Nowy.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Pomiar_Nowy.Text = "Nowy...";
            this.ToolStripMenuItem_Pomiar_Nowy.Click += new System.EventHandler(this.ToolStripMenuItem_Pomiar_Nowy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // ToolStripMenuItem_Widok
            // 
            this.ToolStripMenuItem_Widok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odświeżWykresToolStripMenuItem});
            this.ToolStripMenuItem_Widok.Name = "ToolStripMenuItem_Widok";
            this.ToolStripMenuItem_Widok.Size = new System.Drawing.Size(53, 19);
            this.ToolStripMenuItem_Widok.Text = "Widok";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Temp,
            this.Konc,
            this.Ruch});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(156, 464);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Visible = false;
            this.ID.Width = 5;
            // 
            // Temp
            // 
            this.Temp.Frozen = true;
            this.Temp.HeaderText = "Temp";
            this.Temp.Name = "Temp";
            this.Temp.Width = 40;
            // 
            // Konc
            // 
            this.Konc.Frozen = true;
            this.Konc.HeaderText = "Konc";
            this.Konc.Name = "Konc";
            this.Konc.Width = 60;
            // 
            // Ruch
            // 
            this.Ruch.Frozen = true;
            this.Ruch.HeaderText = "Ruch";
            this.Ruch.Name = "Ruch";
            this.Ruch.Width = 60;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(742, 464);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.checkedListBox1);
            this.splitContainer2.Size = new System.Drawing.Size(582, 464);
            this.splitContainer2.SplitterDistance = 462;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chart2);
            this.splitContainer3.Size = new System.Drawing.Size(462, 464);
            this.splitContainer3.SplitterDistance = 232;
            this.splitContainer3.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Tabela1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(462, 232);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(462, 228);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(116, 464);
            this.checkedListBox1.TabIndex = 0;
            // 
            // odświeżWykresToolStripMenuItem
            // 
            this.odświeżWykresToolStripMenuItem.Name = "odświeżWykresToolStripMenuItem";
            this.odświeżWykresToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.odświeżWykresToolStripMenuItem.Text = "Odśwież wykres";
            this.odświeżWykresToolStripMenuItem.Click += new System.EventHandler(this.odświeżWykresToolStripMenuItem_Click);
            // 
            // EdwinHallC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 487);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EdwinHallC";
            this.Text = "EdwinHall v. 0.001";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Pomiar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_WskazBaze;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EksportujDane;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Pomiar_Nowy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Widok;
        private System.Windows.Forms.ToolStripMenuItem zPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naSerwerzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EksportujWykres;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EksportujTabele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Konc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ądzeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odświeżWykresToolStripMenuItem;
       
    }
}

