using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateShapeComboBox();
            PopulateFontListBox();
        }
        private void PopulateShapeComboBox()
        {
            comboBoxShape.Items.Add("Circle");
            comboBoxShape.Items.Add("Ellipse");
            comboBoxShape.Items.Add("Triangle");
        }

        private void PopulateFontListBox()
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                listBoxFonts.Items.Add(fontFamily.Name);
            }
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshShape();
        }

        private void RefreshShape()
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);

            switch (comboBoxShape.SelectedItem.ToString())
            {
                case "Circle":
                    DrawCircle(graphics);
                    break;
                case "Ellipse":
                    DrawEllipse(graphics);
                    break;
                case "Triangle":
                    DrawTriangle(graphics);
                    break;
                default:
                    break;
            }
        }

        private void DrawCircle(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int diameter = Math.Min(ClientSize.Width, ClientSize.Height);
            int x = (ClientSize.Width - diameter) / 2;
            int y = (ClientSize.Height - diameter) / 2;
            graphics.FillEllipse(Brushes.Blue, x, y, diameter, diameter);
        }

        private void DrawEllipse(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int width = ClientSize.Width / 2;
            int height = ClientSize.Height / 2;
            int x = (ClientSize.Width - width) / 2;
            int y = (ClientSize.Height - height) / 2;
            graphics.FillEllipse(Brushes.Green, x, y, width, height);
        }

        private void DrawTriangle(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Point[] points =
            {
                new Point(ClientSize.Width / 2, 50),
                new Point(50, ClientSize.Height - 50),
                new Point(ClientSize.Width - 50, ClientSize.Height - 50)
            };
            graphics.FillPolygon(Brushes.Red, points);
        }


        private void listBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFonts.SelectedItem != null)
            {
                string selectedFontName = listBoxFonts.SelectedItem.ToString();
                labelFontPreview.Font = new Font(selectedFontName, 12);
                labelFontPreview.Text = "Font Preview";
            }

        }

        private void labelFontPreview_Click(object sender, EventArgs e)
        {

        }
    }
}




