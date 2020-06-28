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

namespace SoundRequest_Installer {
    public partial class Main : Form {

        bool inProgress = true;

        public Main() {
            InitializeComponent();
            Utils.smoothBorder(this, 10);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }

        private void backBtn_OnClick(object sender, EventArgs e) {
            stepBar.Index -= 1;
        }

        private void nextBtn_OnClick(object sender, EventArgs e) {
            stepBar.Index += 1;
        }

        private void minBox_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBox_Click(object sender, EventArgs e) {
            if (inProgress) {
                DialogResult dialog = MessageBox.Show("Install is in progress, do you really want to quit?", "Install is in progress.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dialog == DialogResult.OK) {
                    Close();
                }
            } else {
                Close();
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void nextBtn_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
