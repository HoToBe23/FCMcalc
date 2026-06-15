namespace FCMcalc {
    partial class CalculationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.mutualLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.stationaryLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.importanceIndexesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mutualDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stationayDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.stationaryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.makeReprotButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutualDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationayDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationaryChart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Controls.Add(this.mutualLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(393, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(407, 53);
            this.panel8.TabIndex = 2;
            // 
            // mutualLabel
            // 
            this.mutualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mutualLabel.Location = new System.Drawing.Point(175, 12);
            this.mutualLabel.Name = "mutualLabel";
            this.mutualLabel.Size = new System.Drawing.Size(77, 34);
            this.mutualLabel.TabIndex = 0;
            this.mutualLabel.Text = "Mutual";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Controls.Add(this.stationaryLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(387, 53);
            this.panel7.TabIndex = 1;
            // 
            // stationaryLabel
            // 
            this.stationaryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stationaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationaryLabel.Location = new System.Drawing.Point(137, 12);
            this.stationaryLabel.Name = "stationaryLabel";
            this.stationaryLabel.Size = new System.Drawing.Size(109, 34);
            this.stationaryLabel.TabIndex = 0;
            this.stationaryLabel.Text = "Stationary";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.importanceIndexesLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 56);
            this.panel6.TabIndex = 0;
            // 
            // importanceIndexesLabel
            // 
            this.importanceIndexesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.importanceIndexesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importanceIndexesLabel.Location = new System.Drawing.Point(296, 18);
            this.importanceIndexesLabel.Name = "importanceIndexesLabel";
            this.importanceIndexesLabel.Size = new System.Drawing.Size(196, 32);
            this.importanceIndexesLabel.TabIndex = 0;
            this.importanceIndexesLabel.Text = "Importance Indexes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 383);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.mutualDataGridView);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 310);
            this.panel4.TabIndex = 1;
            // 
            // mutualDataGridView
            // 
            this.mutualDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mutualDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.mutualDataGridView.Location = new System.Drawing.Point(393, 0);
            this.mutualDataGridView.Name = "mutualDataGridView";
            this.mutualDataGridView.Size = new System.Drawing.Size(407, 310);
            this.mutualDataGridView.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.stationaryChart);
            this.panel5.Controls.Add(this.stationayDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(387, 310);
            this.panel5.TabIndex = 0;
            // 
            // stationayDataGridView
            // 
            this.stationayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationayDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.stationayDataGridView.Location = new System.Drawing.Point(0, 0);
            this.stationayDataGridView.Name = "stationayDataGridView";
            this.stationayDataGridView.Size = new System.Drawing.Size(387, 81);
            this.stationayDataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.makeReprotButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 50);
            this.panel3.TabIndex = 0;
            // 
            // stationaryChart
            // 
            chartArea1.Name = "ChartArea1";
            this.stationaryChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.stationaryChart.Legends.Add(legend1);
            this.stationaryChart.Location = new System.Drawing.Point(12, 87);
            this.stationaryChart.Name = "stationaryChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.stationaryChart.Series.Add(series1);
            this.stationaryChart.Size = new System.Drawing.Size(372, 220);
            this.stationaryChart.TabIndex = 1;
            this.stationaryChart.Text = "chart1";
            // 
            // makeReprotButton
            // 
            this.makeReprotButton.Location = new System.Drawing.Point(12, 15);
            this.makeReprotButton.Name = "makeReprotButton";
            this.makeReprotButton.Size = new System.Drawing.Size(776, 23);
            this.makeReprotButton.TabIndex = 0;
            this.makeReprotButton.Text = "Make Report";
            this.makeReprotButton.UseVisualStyleBackColor = true;
            this.makeReprotButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.makeReprotButton_MouseClick);
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculationForm";
            this.Text = "FCMcalc / Results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalculationForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mutualDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationayDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationaryChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView stationayDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView mutualDataGridView;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label importanceIndexesLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label stationaryLabel;
        private System.Windows.Forms.Label mutualLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart stationaryChart;
        private System.Windows.Forms.Button makeReprotButton;
    }
}