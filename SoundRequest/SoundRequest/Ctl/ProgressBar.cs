using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SoundRequest.Ctl {
    public partial class ProgressBar : UserControl {
        private int value = 50;
        private int min = 1;
        private int max = 100;

        [Category("User")]
        public int Value {
            get { return value; }
            set {
                this.value = value;
                update();
            }
        }

        [Category("User")]
        public int Min {
            get { return min; }
            set {
                min = value;
                update();
            }
        }

        [Category("User")]
        public int Max {
            get { return max; }
            set {
                max = value;
                update();
            }
        }

        [Category("User")]
        public int wLoc {
            get { return progressPanel.Width; }
        }

        public ProgressBar() {
            InitializeComponent();
            update();
        }

        private void update() {
            progressPanel.Width = (int)(((double)value / (max - min)) * Width);
            Utils.smoothBorder(this, Height - 2);
            Utils.smoothBorder(progressPanel, Height - 2);
            Refresh();
        }

        private void ProgressBar_Resize(object sender, EventArgs e) {
            update();
        }

        private void progressPanel_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(rectangle, Color.FromArgb(255, 108, 171), Color.FromArgb(115, 102, 255), 65f);
            graphics.FillRectangle(brush, rectangle);
        }
    }
}
