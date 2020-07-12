using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SoundRequest {
    public partial class UserBtn : UserControl {
        private string text = "test";

        [Category("User")]
        public string LabelText {
            get { return text; }
            set {
                text = value;
                textLabel.Text = text;
            }
        }

        [Browsable(true)]
        [Category("User")]
        public event EventHandler OnClick;

        public UserBtn() {
            InitializeComponent();
        }

        private void UserBtn_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(rectangle, Color.FromArgb(255, 108, 171), Color.FromArgb(115, 102, 255), 65f);
            graphics.FillRectangle(brush, rectangle);
        }

        private void UserBtn_Resize(object sender, EventArgs e) {
            Utils.smoothBorder(this, Height);
            Refresh();
        }

        private void textLabel_Click(object sender, EventArgs e) {
            OnClick?.Invoke(this, e);
        }
    }
}
