using FuzzyCognitiveMap;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace FCMcalc {
    public partial class CalculationForm : Form {
        private FCM _fcm;
        private MainForm _prevf;
        public CalculationForm(MainForm prevf, FCM fcm) {
            _fcm = fcm;
            _prevf = prevf;
            this.MaximizeBox = false;
            InitializeComponent();
            RefreshTables();
        }
        private void RefreshTables() {
            //Clear tables
            stationayDataGridView.Rows.Clear();
            stationayDataGridView.Columns.Clear();
            mutualDataGridView.Rows.Clear();
            mutualDataGridView.Columns.Clear();

            //Static indexes
            for (int i = 1; i < _fcm.Concepts.Length; i++) {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = $"I(C{i})";
                col.Name = $"I(C{i})";
                stationayDataGridView.Columns.Add(col);
            }
            stationayDataGridView.ReadOnly = true;
            //Values of stationary indexes
            var row = new ArrayList();
            for (int i = 0; i < _fcm.Concepts.Length - 1; i++) {
                double [] startVector = new double[_fcm.Concepts.Length];
                startVector[i] = 1;
                var result = _fcm.Importance_index(startVector);
                row.Add(result);
            }
            if(stationayDataGridView.Columns.Count > 0)
                stationayDataGridView.Rows.Add(row.ToArray());
            //Chart
            ChartArea area = new ChartArea();
            stationaryChart.ChartAreas.Add(area);
            area.AxisX.Title = "I(Cn)";
            area.AxisY.Title = "Y";
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 1;
            area.AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
            area.AxisY.Interval = 0.1;
            
            Series series = stationaryChart.Series[0];
            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 1;
            series.Name = "I(Cn)";
            series.Color = System.Drawing.Color.Gray;
            for (int i = 0; i < _fcm.Concepts.Length - 1; i++) {
                series.Points.AddXY($"I(C{i + 1})", 
                    Convert.ToDouble(stationayDataGridView.Rows[0].Cells[i].Value));
            }

            int rangeMin = 0;
            int rangeMax = 1;            
            Series sDummy = stationaryChart.Series.Add("dummy");
            sDummy.Color = Color.Transparent;
            sDummy.IsVisibleInLegend = false;
            sDummy.ChartType = SeriesChartType.Point;
            sDummy.Points.AddXY(0, rangeMin);
            sDummy.Points.AddXY(0, rangeMax - 0.2);


            //Mutual indexes
            for (int i = 1; i < _fcm.Concepts.Length - 1; i++) {
                var col = new DataGridViewTextBoxColumn();
                col.HeaderText = $"I(C{i + 1})";
                col.Name = $"I(C{i + 1})";
                mutualDataGridView.Columns.Add(col);
            }
            for (int i = 0; i < _fcm.Concepts.Length - 2; i++) {
                row = new ArrayList();
                for (int j = 1; j < _fcm.Concepts.Length - 1; j++) {
                    if (j <= i) {
                        row.Add("-");
                        continue;
                    }
                    else {
                        double[] startVector = new double[_fcm.Concepts.Length];
                        startVector[i] = 1;
                        startVector[j] = 1;
                        double result = _fcm.Importance_index(startVector);
                        row.Add(result);
                    }
                }
                mutualDataGridView.Rows.Add(row.ToArray());
                mutualDataGridView.Rows[i].HeaderCell.Value = $"I(C{i + 1})";                
            }
            mutualDataGridView.RowHeadersWidth = 70;
            for (int i = 0; i < mutualDataGridView.Columns.Count; i++) {
                mutualDataGridView.Columns[i].Width = 70;
            }
            mutualDataGridView.ReadOnly = true;
            

        }
        private void SaveResultsToFile(string path) {

            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8)) {

                writer.WriteLine();
                writer.WriteLine("Concepts");
                writer.WriteLine();

                for (int i = 0; i < _fcm.Concepts.Length - 1; i++) {
                    writer.WriteLine($"|{"C" + (i + 1).ToString(), 10}|{_fcm.Concepts[i],100}|");
                }
                writer.WriteLine($"|{"C" + (0).ToString(),10}|{_fcm.Concepts[_fcm.Concepts.Length - 1],100}|");

                writer.WriteLine();
                writer.WriteLine("Weights");
                writer.WriteLine();

                writer.Write($"|{" ",10}");
                for (int i = 0; i < _fcm.Weigths.GetLength(1) - 1; i++) {
                    writer.Write($"|{"C" + (i + 1).ToString(),10}");
                }
                writer.WriteLine($"|{"C" + (0).ToString(),10}|");
                
                double val;
                for (int i = 0; i < _fcm.Weigths.GetLength(0) - 1; i++) {
                    writer.Write($"|{"C" + (i + 1).ToString(),10}");
                    for (int j = 0; j < _fcm.Weigths.GetLength(1) - 1; j++) {
                        val = _fcm.Weigths[i, j];
                        writer.Write($"|{val,10:F4}");
                    }
                    val = _fcm.Weigths[i, _fcm.Weigths.GetLength(1) - 1];
                    writer.WriteLine($"|{val,10:F4}|");
                }
                writer.Write($"|{"C" + (0).ToString(),10}");
                for (int j = 0; j < _fcm.Weigths.GetLength(1) - 1; j++) {
                    val = _fcm.Weigths[_fcm.Weigths.GetLength(1) - 1, j];
                    writer.Write($"|{val,10:F4}");
                }
                val = _fcm.Weigths[_fcm.Weigths.GetLength(1) - 1, _fcm.Weigths.GetLength(1) - 1];
                writer.WriteLine($"|{val,10:F4}|");


                writer.WriteLine();
                writer.WriteLine("Stationary Indexes");
                writer.WriteLine();
                // header                              
                for (int i = 0; i < stationayDataGridView.Columns.Count; i++) {
                    writer.Write($"|{stationayDataGridView.Columns[i].HeaderText, 10}");
                }
                writer.WriteLine("|");
                //rows
                foreach (DataGridViewRow row in stationayDataGridView.Rows) {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < row.Cells.Count; i++) {
                        val = Convert.ToDouble(row.Cells[i].Value);
                        writer.Write($"|{val,10:F4}");

                    }
                    writer.WriteLine("|");
                }

                writer.WriteLine();
                writer.WriteLine("Mutual Indexes");
                writer.WriteLine();
                // header                              
                for (int i = -1; i < mutualDataGridView.Columns.Count; i++) {
                    if (i == -1) {
                        writer.Write($"|{" ",10}");
                        continue;
                    }                    
                    else
                        writer.Write($"|{mutualDataGridView.Columns[i].HeaderText,10}");
                }
                writer.WriteLine("|");
                //rows
                foreach (DataGridViewRow row in mutualDataGridView.Rows) {
                    if (row.IsNewRow) continue;

                    writer.Write($"|{row.HeaderCell.Value.ToString(),10}");

                    for (int i = 0; i < row.Cells.Count; i++) {
                        if (row.Cells[i].Value.ToString() == "-") {
                            writer.Write($"|{"-",10}");
                        }
                        else { 
                            var val2 = Convert.ToDouble(row.Cells[i].Value);
                            writer.Write($"|{val2,10:F4}");
                        }

                    }
                    writer.WriteLine("|");
                }

            }

            MessageBox.Show("File saved:\n" + path);
        }
        
        private void makeReprotButton_MouseClick(object sender, MouseEventArgs e) {
            string path = Application.StartupPath + @"\results.txt";
            SaveResultsToFile(path);
        }
        private void CalculationForm_FormClosed(object sender, FormClosedEventArgs e) {
            _prevf.Show();
        }

        
    }
}
