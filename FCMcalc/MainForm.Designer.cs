namespace FCMcalc {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewWeights = new System.Windows.Forms.DataGridView();
            this.First = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addWeightButton = new System.Windows.Forms.Button();
            this.secondConceptComboBox = new System.Windows.Forms.ComboBox();
            this.firstConceptComboBox = new System.Windows.Forms.ComboBox();
            this.matrixInputButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewConcepts = new System.Windows.Forms.DataGridView();
            this.Cn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ConceptInputLabel = new System.Windows.Forms.Label();
            this.addConceptButton = new System.Windows.Forms.Button();
            this.conceptTextBox = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Results = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeights)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcepts)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 512);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.dataGridViewWeights);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(354, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 512);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewWeights
            // 
            this.dataGridViewWeights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.First,
            this.Second,
            this.Weight});
            this.dataGridViewWeights.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewWeights.Location = new System.Drawing.Point(0, 162);
            this.dataGridViewWeights.Name = "dataGridViewWeights";
            this.dataGridViewWeights.Size = new System.Drawing.Size(360, 350);
            this.dataGridViewWeights.TabIndex = 1;
            // 
            // First
            // 
            this.First.HeaderText = "First";
            this.First.Name = "First";
            this.First.ReadOnly = true;
            // 
            // Second
            // 
            this.Second.HeaderText = "Second";
            this.Second.Name = "Second";
            this.Second.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.weightTextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.addWeightButton);
            this.panel4.Controls.Add(this.secondConceptComboBox);
            this.panel4.Controls.Add(this.firstConceptComboBox);
            this.panel4.Controls.Add(this.matrixInputButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 120);
            this.panel4.TabIndex = 0;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Location = new System.Drawing.Point(149, 75);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(116, 20);
            this.weightTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Influence Weigths Input";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addWeightButton
            // 
            this.addWeightButton.Location = new System.Drawing.Point(271, 75);
            this.addWeightButton.Name = "addWeightButton";
            this.addWeightButton.Size = new System.Drawing.Size(75, 20);
            this.addWeightButton.TabIndex = 5;
            this.addWeightButton.Text = "Add Weight";
            this.addWeightButton.UseVisualStyleBackColor = true;
            this.addWeightButton.Click += new System.EventHandler(this.addWeightButton_Click);
            // 
            // secondConceptComboBox
            // 
            this.secondConceptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondConceptComboBox.FormattingEnabled = true;
            this.secondConceptComboBox.Location = new System.Drawing.Point(83, 74);
            this.secondConceptComboBox.Name = "secondConceptComboBox";
            this.secondConceptComboBox.Size = new System.Drawing.Size(60, 21);
            this.secondConceptComboBox.TabIndex = 4;
            // 
            // firstConceptComboBox
            // 
            this.firstConceptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstConceptComboBox.FormattingEnabled = true;
            this.firstConceptComboBox.Location = new System.Drawing.Point(17, 74);
            this.firstConceptComboBox.Name = "firstConceptComboBox";
            this.firstConceptComboBox.Size = new System.Drawing.Size(60, 21);
            this.firstConceptComboBox.TabIndex = 3;
            // 
            // matrixInputButton
            // 
            this.matrixInputButton.Location = new System.Drawing.Point(17, 48);
            this.matrixInputButton.Name = "matrixInputButton";
            this.matrixInputButton.Size = new System.Drawing.Size(327, 20);
            this.matrixInputButton.TabIndex = 2;
            this.matrixInputButton.Text = "Matrix Input";
            this.matrixInputButton.UseVisualStyleBackColor = true;
            this.matrixInputButton.Click += new System.EventHandler(this.matrixInputButton_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.dataGridViewConcepts);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 512);
            this.panel5.TabIndex = 2;
            // 
            // dataGridViewConcepts
            // 
            this.dataGridViewConcepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConcepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cn,
            this.ConceptName,
            this.Delete});
            this.dataGridViewConcepts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewConcepts.Location = new System.Drawing.Point(0, 162);
            this.dataGridViewConcepts.Name = "dataGridViewConcepts";
            this.dataGridViewConcepts.Size = new System.Drawing.Size(348, 350);
            this.dataGridViewConcepts.TabIndex = 1;
            this.dataGridViewConcepts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConcepts_CellClick);
            this.dataGridViewConcepts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConcepts_CellMouseClick);
            this.dataGridViewConcepts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConcepts_CellValueChanged);
            // 
            // Cn
            // 
            this.Cn.HeaderText = "Cn";
            this.Cn.Name = "Cn";
            this.Cn.ReadOnly = true;
            // 
            // ConceptName
            // 
            this.ConceptName.HeaderText = "ConceptName";
            this.ConceptName.Name = "ConceptName";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Controls.Add(this.ConceptInputLabel);
            this.panel6.Controls.Add(this.addConceptButton);
            this.panel6.Controls.Add(this.conceptTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(348, 120);
            this.panel6.TabIndex = 0;
            // 
            // ConceptInputLabel
            // 
            this.ConceptInputLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConceptInputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConceptInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConceptInputLabel.Location = new System.Drawing.Point(0, 0);
            this.ConceptInputLabel.Name = "ConceptInputLabel";
            this.ConceptInputLabel.Size = new System.Drawing.Size(348, 34);
            this.ConceptInputLabel.TabIndex = 2;
            this.ConceptInputLabel.Text = "Concept Input";
            this.ConceptInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addConceptButton
            // 
            this.addConceptButton.Location = new System.Drawing.Point(190, 62);
            this.addConceptButton.Name = "addConceptButton";
            this.addConceptButton.Size = new System.Drawing.Size(145, 20);
            this.addConceptButton.TabIndex = 1;
            this.addConceptButton.Text = "Add Concept";
            this.addConceptButton.UseVisualStyleBackColor = true;
            this.addConceptButton.Click += new System.EventHandler(this.addConceptButton_Click);
            // 
            // conceptTextBox
            // 
            this.conceptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conceptTextBox.Location = new System.Drawing.Point(15, 62);
            this.conceptTextBox.Name = "conceptTextBox";
            this.conceptTextBox.Size = new System.Drawing.Size(167, 20);
            this.conceptTextBox.TabIndex = 0;
            // 
            // N
            // 
            this.N.HeaderText = "№";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Results);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 521);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 41);
            this.panel2.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(12, 10);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(690, 20);
            this.Results.TabIndex = 6;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.addConceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FCMcalc";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeights)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcepts)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewWeights;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addWeightButton;
        private System.Windows.Forms.ComboBox secondConceptComboBox;
        private System.Windows.Forms.ComboBox firstConceptComboBox;
        private System.Windows.Forms.Button matrixInputButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewConcepts;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label ConceptInputLabel;
        private System.Windows.Forms.Button addConceptButton;
        private System.Windows.Forms.TextBox conceptTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Results;     
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptName;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn First;
        private System.Windows.Forms.DataGridViewTextBoxColumn Second;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}

