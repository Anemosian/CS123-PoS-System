namespace POS_System
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stocktab = new System.Windows.Forms.TabPage();
            this.registerKeypad1 = new Keypad.RegisterKeypad();
            this.ordertab = new System.Windows.Forms.TabPage();
            this.salestab = new System.Windows.Forms.TabPage();
            this.editortab = new System.Windows.Forms.TabPage();
            this.editor1 = new Keypad.Editor();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.ordertab.SuspendLayout();
            this.salestab.SuspendLayout();
            this.editortab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ordertab);
            this.tabControl1.Controls.Add(this.stocktab);
            this.tabControl1.Controls.Add(this.salestab);
            this.tabControl1.Controls.Add(this.editortab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 588);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // stocktab
            // 
            this.stocktab.Location = new System.Drawing.Point(4, 22);
            this.stocktab.Name = "stocktab";
            this.stocktab.Padding = new System.Windows.Forms.Padding(3);
            this.stocktab.Size = new System.Drawing.Size(828, 562);
            this.stocktab.TabIndex = 1;
            this.stocktab.Text = "STOCK";
            this.stocktab.UseVisualStyleBackColor = true;
            this.stocktab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // registerKeypad1
            // 
            this.registerKeypad1.Location = new System.Drawing.Point(10, 43);
            this.registerKeypad1.Name = "registerKeypad1";
            this.registerKeypad1.Size = new System.Drawing.Size(805, 521);
            this.registerKeypad1.TabIndex = 1;
            this.registerKeypad1.Load += new System.EventHandler(this.registerKeypad1_Load);
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.registerKeypad1);
            this.ordertab.Location = new System.Drawing.Point(4, 22);
            this.ordertab.Name = "ordertab";
            this.ordertab.Padding = new System.Windows.Forms.Padding(3);
            this.ordertab.Size = new System.Drawing.Size(828, 562);
            this.ordertab.TabIndex = 0;
            this.ordertab.Text = "ORDER";
            this.ordertab.UseVisualStyleBackColor = true;
            this.ordertab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // salestab
            // 
            this.salestab.Controls.Add(this.chart1);
            this.salestab.Location = new System.Drawing.Point(4, 22);
            this.salestab.Name = "salestab";
            this.salestab.Padding = new System.Windows.Forms.Padding(3);
            this.salestab.Size = new System.Drawing.Size(828, 562);
            this.salestab.TabIndex = 2;
            this.salestab.Text = "SALES";
            this.salestab.UseVisualStyleBackColor = true;
            // 
            // editortab
            // 
            this.editortab.Controls.Add(this.editor1);
            this.editortab.Location = new System.Drawing.Point(4, 22);
            this.editortab.Name = "editortab";
            this.editortab.Padding = new System.Windows.Forms.Padding(3);
            this.editortab.Size = new System.Drawing.Size(828, 562);
            this.editortab.TabIndex = 3;
            this.editortab.Text = "EDITOR";
            this.editortab.UseVisualStyleBackColor = true;
            // 
            // editor1
            // 
            this.editor1.Location = new System.Drawing.Point(10, 43);
            this.editor1.Name = "editor1";
            this.editor1.Size = new System.Drawing.Size(820, 520);
            this.editor1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(30, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(407, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ordertab.ResumeLayout(false);
            this.salestab.ResumeLayout(false);
            this.editortab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ordertab;
        private Keypad.RegisterKeypad registerKeypad1;
        private System.Windows.Forms.TabPage stocktab;
        private System.Windows.Forms.TabPage salestab;
        private System.Windows.Forms.TabPage editortab;
        private Keypad.Editor editor1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

