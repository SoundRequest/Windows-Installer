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
        public Main() {
            InitializeComponent();
            Utils.smoothBorder(this, 10);

            coverPanel.Location = new Point(0, 0);
            coverPanel.Size = Size;
            closeLoaderBox.Location = closeBox.Location;

            //infoLabel.Text = "Loading updated data from the server.\nThis might take a few seconds.";
            statusLabel.Text = "LOADING";
            infoLabel.Text = "최신 정보를 서버에서 불러오는 중입니다.\n이 작업은 몇초정도 소요될 수 있습니다.";
            updateStatus();
        }

        private void Main_Load(object sender, EventArgs e) {
            Visible = true;
            Refresh();

            mainFlowPanel.Left = (Width - mainFlowPanel.Width) / 2;

            if (Setting.LoadData()) {
                coverPanel.Visible = false;
            } else {
                statusLabel.Text = "Error";
                //infoLabel.Text = "An unexpected error has occurred while parsing install data.\nPlease contact with administrator.";
                infoLabel.Text = "설치 데이터를 불러오는 도중 오류가 발생했습니다.\n이 오류가 지속되면 관리자에게 문의해주세요.";
                updateStatus();
            }
            Setting.inProgress = false;
        }

        private void updateStatus() {
            statusLabel.Location = new Point((Width - statusLabel.Width) / 2, (Height - statusLabel.Height - infoLabel.Height) / 2);
            infoLabel.Location = new Point((Width - infoLabel.Width) / 2, statusLabel.Top + statusLabel.Height);
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
            if (Setting.inProgress) {
                //DialogResult dialog = MessageBox.Show("Install is in progress, do you really want to quit?", "Install is in progress.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                DialogResult dialog = MessageBox.Show("설치가 진행 중입니다. 정말로 종료 하시겠습니까?", "설치 진행중", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK) {
                    Close();
                }
            } else {
                Close();
            }
        }

        private void Main_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void mainFlowPanel_Paint(object sender, PaintEventArgs e) {

        }
    }
}
