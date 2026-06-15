namespace FCMcalc {
    partial class MatrixInputForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixInputForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.matrixInputLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.weightsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightsDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.matrixInputLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 47);
            this.panel1.TabIndex = 0;
            // 
            // matrixInputLabel
            // 
            this.matrixInputLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixInputLabel.Location = new System.Drawing.Point(0, 0);
            this.matrixInputLabel.Name = "matrixInputLabel";
            this.matrixInputLabel.Size = new System.Drawing.Size(502, 47);
            this.matrixInputLabel.TabIndex = 0;
            this.matrixInputLabel.Text = "Matrix Input";
            this.matrixInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.weightsDataGridView);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 430);
            this.panel2.TabIndex = 1;
            // 
            // weightsDataGridView
            // 
            this.weightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.weightsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.weightsDataGridView.Name = "weightsDataGridView";
            this.weightsDataGridView.Size = new System.Drawing.Size(502, 371);
            this.weightsDataGridView.TabIndex = 2;
            this.weightsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.weightsDataGridView_CellMouseClick);
            this.weightsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.weightsDataGridView_CellValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cancelButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(502, 53);
            this.panel4.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 18);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(478, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel Changes";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MatrixInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatrixInputForm";
            this.Text = "FCMcalc / Matrix Input";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MatrixInputForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weightsDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label matrixInputLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView weightsDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button cancelButton;
    }
}