using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames
{
    public partial class Bar : UserControl
    {
        private double min = 0;
        private double max = 1000;
        private double current = 500;

        public double Current {
            get { return current; }
            set { 
                current = value;
                barValues.Text = current + "/" + max;
                UpdateValue();
            }
        }


        private double Percent {
            get { return (current - min) / (max - min); }
        }

        public string BarName {
            set { barName.Text = value; }
        }

        public Bar() {
            InitializeComponent();
        }

        public void InitValues(double min, double max, Color color) {
            this.min = min;
            this.max = max;
            pictureBox1.BackColor = color;
        }

        private void panel1_Resize(object sender, EventArgs e) {
            UpdateValue();
        }

        private void UpdateValue() {
            pictureBox1.Width = (int)(panel1.Width * Percent);
        }
    }
}
