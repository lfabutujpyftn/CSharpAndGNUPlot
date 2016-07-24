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
        private Plot.Plot plot;
        private TestGenerator.Generator gen;
        string redactor(string arg)
        {
            return arg.Replace('\\', '/');
        }
        public MainForm()
        {
            InitializeComponent();
            colorcomboBox.SelectedItem = "Red";
            drawtypecomboBox.SelectedItem = "Lines";
            plot = new Plot.Plot();
            gen = new TestGenerator.Generator();

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Generatebutton.Enabled = false;
                gen.Start = (int)startnumericUpDown.Value;
                gen.Finish = (int)finishnumericUpDown.Value;
                gen.Step = (double)stepnumericUpDown.Value;
                gen.From = (int)fromnumericUpDown.Value;
                gen.To = (int)tonumericUpDown.Value;
                gen.Filename = saveFile.FileName;
                gen.genTest();
                Generatebutton.Enabled = true;
            }
            else return;

        }

        private void plotbutton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                plotbutton.Enabled = false;
                plot.XTitle = xlabeltextBox.Text;
                plot.YTitle = ylabeltextBox.Text;
                plot.Title = labeltextBox.Text;
                //labeltextBox.Text = openFile.FileName;
                switch (drawtypecomboBox.SelectedItem.ToString())
                {
                    case "Lines":
                        plot.DrawType = Plot.DrawType.Lines;
                        break;
                    case "Points":
                        plot.DrawType = Plot.DrawType.Points;
                        break;
                    default:
                        break;
                }
                switch (colorcomboBox.SelectedItem.ToString())
                {
                    case "Red":
                        plot.Color = Plot.Color.Red;
                        break;
                    case "Green":
                        plot.Color = Plot.Color.Green;
                        break;
                    case "Blue":
                        plot.Color = Plot.Color.Blue;
                        break;
                    case "Black":
                        plot.Color = Plot.Color.Black;
                        break;
                    default:
                        break;
                }
                plot.DrawFile(redactor(openFile.FileName));
                plotbutton.Enabled = true;
            }
            else return;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //plot.Close();
        }
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            plot.Close();
        }
    }
}
