using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test
{
    public partial class MainForm : Form
    {
        private Plot.Plot _plot;
        private TestGenerator.Generator _gen;
        string Redactor(string arg)
        {
            return arg.Replace('\\', '/');
        }
        public MainForm()
        {
            InitializeComponent();
            //colorcomboBox.SelectedItem = "Red";
            drawtypecomboBox.SelectedItem = "Lines";
            _plot = new Plot.Plot();
            _gen = new TestGenerator.Generator();

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Generatebutton.Enabled = false;
                _gen.Start = (int)startnumericUpDown.Value;
                _gen.Finish = (int)finishnumericUpDown.Value;
                _gen.Step = (double)stepnumericUpDown.Value;
                _gen.From = (int)fromnumericUpDown.Value;
                _gen.To = (int)tonumericUpDown.Value;
                _gen.Filename = saveFile.FileName;
                _gen.GenTest();
                Generatebutton.Enabled = true;
            }
            else return;

        }

        private void plotbutton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                plotbutton.Enabled = false;
                _plot.XTitle = xlabeltextBox.Text;
                _plot.YTitle = ylabeltextBox.Text;
                _plot.Title = labeltextBox.Text;
                //labeltextBox.Text = openFile.FileName;
                switch (drawtypecomboBox.SelectedItem.ToString())
                {
                    case "Lines":
                        _plot.DrawType = Plot.DrawType.Lines;
                        break;
                    case "Points":
                        _plot.DrawType = Plot.DrawType.Points;
                        break;
                    default:
                        break;
                }
               /* switch (colorcomboBox.SelectedItem.ToString())
                {
                    case "Red":
                        _plot.Color = Plot.Color.Red;
                        break;
                    case "Green":
                        _plot.Color = Plot.Color.Green;
                        break;
                    case "Blue":
                        _plot.Color = Plot.Color.Blue;
                        break;
                    case "Black":
                        _plot.Color = Plot.Color.Black;
                        break;
                    default:
                        break;
                }*/
                _plot.Color = (colorDialog.Color.ToArgb() & 0xffffff).ToString("X");
                _plot.DrawFile(Redactor(openFile.FileName));
                plotbutton.Enabled = true;
            }
            else return;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //_plot.Close();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _plot.Close();
        }

        private void colorbutton_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int color = colorDialog.Color.ToArgb();
                colorbutton.BackColor = colorDialog.Color;
            }
        }
    }
}
