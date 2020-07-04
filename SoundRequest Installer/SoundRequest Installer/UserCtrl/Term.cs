using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SoundRequest_Installer.UserCtrl {
    public partial class Term : UserControl {

        private string text = "Term of Use";

        [Category("User")]
        public string LabelText {
            get { return text; }
            set {
                text = value;
                textLabel.Text = text;
            }
        }

        [Category("User")]
        public string URL { get; set; }

        public Term() {
            InitializeComponent();
            sizeUpdate();
        }

        private void sizeUpdate() {
            mainPanel.Size = new Size(Width - 10, Height - 10);
            termBox.Size = new Size(mainPanel.Height - 10, mainPanel.Height - 10);
            termBox.Location = new Point(mainPanel.Width - termBox.Width - 5, (mainPanel.Height - termBox.Height) / 2);
            Utils.smoothBorder(this, 20);
            Utils.smoothBorder(mainPanel, 20);
        }

        private void Term_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(rectangle, Color.FromArgb(255, 108, 171), Color.FromArgb(115, 102, 255), 65f);
            graphics.FillRectangle(brush, rectangle);
        }

        private void Term_Resize(object sender, EventArgs e) {
            sizeUpdate();
        }

        private void textLabel_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(URL);
        }
    }
}
