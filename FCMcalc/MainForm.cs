using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyCognitiveMap;

namespace FCMcalc {
    public partial class MainForm : Form {
        private FCM _fcm;
        public FCM Fcm { get => _fcm; set => _fcm = value; }
        public MainForm(FCM empty_fcm) {
            Fcm = empty_fcm;
            this.MaximizeBox = false;
            InitializeComponent();
        }
        private void RefreshTables() {
            //refresh concepts table
            dataGridViewConcepts.Rows.Clear();
            ArrayList row = new ArrayList();
            for (int i = 0; i < Fcm.Concepts.Length - 1; i++) {
                row = new ArrayList();
                row.Add("C" + (i + 1).ToString());
                row.Add(Fcm.Concepts[i]);
                row.Add("Delete");
                dataGridViewConcepts.Rows.Add(row.ToArray());
            }
            row = new ArrayList();
            row.Add("C0");
            row.Add(Fcm.Concepts[Fcm.Concepts.Length - 1]);
            row.Add("Delete");
            dataGridViewConcepts.Rows.Add(row.ToArray());
            //paint the buttons red
            DataGridViewButtonColumn c =
                (DataGridViewButtonColumn)dataGridViewConcepts.Columns[2];
            c.UseColumnTextForButtonValue = true;
            c.Text = "Delete";
            c.FlatStyle = FlatStyle.Flat;
            c.DefaultCellStyle.ForeColor = Color.Red;
            c.DefaultCellStyle.SelectionForeColor = Color.Red;

            //refresh weights table
            dataGridViewWeights.Rows.Clear();
            for (int i = 0; i < Fcm.Weigths.GetLength(0); i++) {
                for (int j = 0; j < Fcm.Weigths.GetLength(1); j++) {
                    if (Fcm.Weigths[i, j] != 0 && i != j) {
                        row = new ArrayList();
                        int I = i == Fcm.Weigths.GetLength(0) - 1 ? 0 : i + 1;
                        int J = j == Fcm.Weigths.GetLength(0) - 1 ? 0 : j + 1;
                        row.Add("C" + I.ToString());
                        row.Add("C" + J.ToString());
                        row.Add(Fcm.Weigths[i, j]);
                        dataGridViewWeights.Rows.Add(row.ToArray());
                    }
                }
            }

            //comboboxes for weights table
            firstConceptComboBox.Items.Clear();
            secondConceptComboBox.Items.Clear();
            row = new ArrayList();
            for (int i = 1; i < Fcm.Concepts.Length; i++) {
                row.Add("C" + i.ToString());
            }
            row.Add("C0");

            firstConceptComboBox.Items.AddRange(row.ToArray());
            secondConceptComboBox.Items.AddRange(row.ToArray());
        }
        private void Form1_Load(object sender, EventArgs e) {
            RefreshTables();
        }

        private void dataGridViewConcepts_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 2) {
                try {
                    int index;
                    if (e.RowIndex == 0)
                        index = Fcm.Concepts.Length - 1;
                    else
                        index = e.RowIndex + 1;
                    _fcm.RemoveConcept(e.RowIndex);
                    RefreshTables();
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private string conceptBuffer;
        bool skip_check = false;

        private void dataGridViewConcepts_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1 && e.RowIndex > -1) {
                var buf = dataGridViewConcepts.Rows[e.RowIndex].Cells[1].Value;
                string value = buf is null ? null : buf.ToString().Trim();
                if (value == "" || value is null) {
                    MessageBox.Show("You entered nothing!");
                    skip_check = false;
                    dataGridViewConcepts.Rows[e.RowIndex].Cells[1].Value = conceptBuffer;
                    return;
                }
                try {                    
                    if (!skip_check) {
                        _fcm.EditConcept(e.RowIndex, value);
                        RefreshTables();
                    }
                    skip_check = false;
                }
                catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                    skip_check = true;
                    dataGridViewConcepts.Rows[e.RowIndex].Cells[1].Value = conceptBuffer;
                }
            }
        }
        private void dataGridViewConcepts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.ColumnIndex == 1 && e.RowIndex > -1 && e.RowIndex < _fcm.Concepts.Length) {
                var a = dataGridViewConcepts.Rows[e.RowIndex].Cells[1].Value.ToString();
                conceptBuffer = a is null ? "" : a;
            }
        }

        private void addConceptButton_Click(object sender, EventArgs e) {
            string text = conceptTextBox.Text.Trim(' ');
            if (text == "") {
                MessageBox.Show("Concept name cannot be empty.");
                return;
            }
            conceptTextBox.Text = "";
            _fcm.AddConcept(text);
            RefreshTables();
        }

        private void addWeightButton_Click(object sender, EventArgs e) {
            weightTextBox.Text = weightTextBox.Text.Trim(' ');
            if (firstConceptComboBox.SelectedIndex == -1
                || secondConceptComboBox.SelectedIndex == -1) {
                MessageBox.Show("Please select concepts. ");
                weightTextBox.Text = "";
                return;
            }
            if (firstConceptComboBox.SelectedIndex == secondConceptComboBox.SelectedIndex) {
                MessageBox.Show("Concepts must be different.");
                weightTextBox.Text = "";
                return;
            }
            if (weightTextBox.Text.Trim() == ""){
                MessageBox.Show("You entered nothing!");
                return;
            }
            try {
                double weight = Convert.ToDouble(weightTextBox.Text);

                int first = Convert.ToInt16(firstConceptComboBox.Text.Trim('C'));
                int second = Convert.ToInt16(secondConceptComboBox.Text.Trim('C'));

                _fcm.EditWeigth(first, second, weight);
            }
            catch (FormatException exeption) {
                MessageBox.Show("Format is not right");
                weightTextBox.Text = "";
                return;
            }
            catch (ArgumentException exeption) {
                MessageBox.Show(exeption.Message);
                weightTextBox.Text = "";
                return;
            }
            weightTextBox.Text = "";
            RefreshTables();
        }

        private void matrixInputButton_Click(object sender, EventArgs e) {
            Form mif = new MatrixInputForm(this, _fcm);
            this.Hide();
            mif.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e) {
            RefreshTables();
        }

        private void Results_Click(object sender, EventArgs e) {
            Form mif = new CalculationForm(this, _fcm);
            this.Hide();
            mif.Show();
        }
    }
}
