using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using FuzzyCognitiveMap;


namespace FCMcalc {
    public partial class MatrixInputForm : Form {
        private FCM _fcm;
        private MainForm _prevf;
        private double[,] cancelWeights;         
        public MatrixInputForm(MainForm prevf, FCM fcm) {
            _fcm = fcm;
            _prevf = prevf;
            this.MaximizeBox = false;
            cancelWeights = _fcm.Weigths.Clone() as double[,];
            InitializeComponent();
            RefreshTable();
        }
        private void RefreshTable() {
            //Clear table
            weightsDataGridView.Columns.Clear();
            weightsDataGridView.Rows.Clear();

            //columns
            int columnLength = _fcm.Concepts.Length;
            DataGridViewTextBoxColumn col;
            for (int i = 1; i < columnLength; i++) {
                col = new DataGridViewTextBoxColumn();
                col.HeaderText = $"C{i}";
                col.Name = $"C{i}";
                weightsDataGridView.Columns.Add(col);
            }
            col = new DataGridViewTextBoxColumn();
            col.HeaderText = $"C0";
            col.Name = $"C0";
            weightsDataGridView.Columns.Add(col);

            weightsDataGridView.RowHeadersWidth = 50;
            for (int i = 0; i < columnLength; i++) {
                weightsDataGridView.Columns[i].Width = 40;
            }

            //rows 
            ArrayList row;
            for (int i = 0; i < columnLength - 1; i++) {
                row = new ArrayList();
                for (int j = 0; j < columnLength; j++) {
                    row.Add(_fcm.Weigths[i, j]);
                }
                weightsDataGridView.Rows.Add(row.ToArray());
                weightsDataGridView.Rows[i].HeaderCell.Value = $"C{i + 1}";
            }
            row = new ArrayList();
            for (int j = 0; j < columnLength; j++) {
                row.Add(_fcm.Weigths[columnLength - 1, j]);
            }
            weightsDataGridView.Rows.Add(row.ToArray());
            weightsDataGridView.Rows[columnLength - 1].HeaderCell.Value = $"C0";

            //make diagonal cells readonly and gray
            weightsDataGridView.AllowUserToAddRows = false;
            for (int i = 0; i < Math.Min(weightsDataGridView.Rows.Count,
                                          weightsDataGridView.Columns.Count); i++) {
                DataGridViewCell cell = weightsDataGridView[i, i];

                cell.ReadOnly = true;
                cell.Style.BackColor = Color.LightGray;
            }
        }
        private void MatrixInputForm_FormClosed(object sender, FormClosedEventArgs e) {
            _prevf.Show();            
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            _fcm.Weigths = cancelWeights.Clone() as double[,];
            RefreshTable();
        }

        string weightBuffer;
        bool check = false;

        private void weightsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {              

            if (e.RowIndex > -1 && e.RowIndex < _fcm.Concepts.Length) {
                var a = weightsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                weightBuffer = a is null ? "" : a;
                check = true;
            }
        }
        private void weightsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && check) {                               
                var buf = weightsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string value = buf is null ? null : buf.ToString().Trim();
                if (value == "" || value is null) {
                    MessageBox.Show("You entered nothing!");
                    check = false;
                    weightsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = weightBuffer;
                    RefreshTable();
                    return;
                }
                try {                    
                    int first = Convert.ToInt16(weightsDataGridView.Rows[e.RowIndex].HeaderCell.Value.ToString().Trim('C'));
                    int second = Convert.ToInt16(weightsDataGridView.Columns[e.ColumnIndex].HeaderText.Trim('C'));
                    _fcm.EditWeigth(first, second, 
                        Convert.ToDouble(value));  
                    check = false;
                }                
                catch (FormatException exeption) {
                    MessageBox.Show("Format is not right");
                    check = false;
                    weightsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = weightBuffer;
                    RefreshTable();
                    return;
                }
                catch (ArgumentException exeption) {
                    MessageBox.Show(exeption.Message);
                    check = false;
                    weightsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = weightBuffer;
                    RefreshTable();
                    return;
                }
               
            }
        }
    }
}
