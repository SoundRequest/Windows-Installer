using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace SoundRequest {
    public partial class Main : Form {
        string tempLoc;
        bool installed = false;

        public Main() {
            InitializeComponent();
            Utils.smoothBorder(this, 10);
            Utils.smoothBorder(installLoc, installLoc.Height / 2);
            coverPanel.Location = new Point(0, 0);
            coverPanel.Size = Size;
            closeLoaderBox.Location = closeBox.Location;
            installText.Left = (Width - installText.Width) / 2;
            label2.Location = new Point(installText.Left, installText.Top + installText.Height + 5);
            installLoc.Location = new Point(label2.Left, label2.Top + label2.Height + 2);
            changeLoc.Location = new Point(installLoc.Left + installLoc.Width + 5, installLoc.Top + (installLoc.Height - changeLoc.Height) / 2);
            shortcut.Location = new Point(installLoc.Left + 2, installLoc.Top + installLoc.Height + 2);
            install.Left = changeLoc.Left + changeLoc.Width - install.Width;

            progressBar1.Value = 0;
            progressText.Text = "";

            progressBar1.Location = new Point((Width - progressBar1.Width) / 2, installText.Top + installText.Height + 10);
            progressText.Location = new Point(progressBar1.Left + progressBar1.wLoc - progressText.Width / 2, progressBar1.Top + progressBar1.Height + 2);

            tempLoc = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            installLoc.Text = tempLoc;
            statusLabel.Text = "LOADING";
            infoLabel.Text = "최신 정보를 서버에서 불러오는 중입니다.\n이 작업은 몇초정도 소요될 수 있습니다.";
            updateStatus();
        }

        private void Main_Load(object sender, EventArgs e) {
            Visible = true;
            Refresh();

            if (Setting.LoadData()) {
                Text = $"SoundRequest Installer Prototype ({Setting.programVer})";
                installText.Text = $"SoundRequest Prototype 최신버전({Setting.programVer})을 설치합니다.\n설치 위치를 지정하신 후, '설치'를 클릭하세요.";
                verText.Text = $"{Setting.lastUpdated}";
                verText.Location = new Point(Width - verText.Width - 10, Height - verText.Height - 10);
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

        private void changeLoc_OnClick(object sender, EventArgs e) {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Select install location.";
            if (folderBrowser.ShowDialog() == DialogResult.OK) {
                installLoc.Text = Path.GetDirectoryName(folderBrowser.FileName);
            }
        }

        private void install_OnClick(object sender, EventArgs e) {
            if (!installed) {
                installLoc.Visible = false;
                changeLoc.Visible = false;
                install.Visible = false;
                shortcut.Visible = false;
                label2.Visible = false;

                Setting.inProgress = true;
                installText.Text = $"SoundRequest Prototype 최신버전({Setting.programVer})의 설치가 진행중입니다.\n이 작업은 몇분정도 소요될 수 있습니다.";
                progressBar1.Visible = true;
                progressText.Visible = true;

                tempLoc = installLoc.Text;

                using (WebClient wc = new WebClient()) {
                    wc.DownloadProgressChanged += progressTextUpdate;
                    wc.DownloadFileAsync(
                        new Uri(Setting.downloadURL),
                        tempLoc + "\\SR_Temp.zip"
                    );
                    wc.DownloadFileCompleted += Completed;
                }
            } else {
                Close();
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            changeProText("다운로드 완료");

            if (Directory.Exists(tempLoc + "\\SoundRequest")) {
                try {
                    Directory.Delete(tempLoc + "\\SoundRequest", true);
                } catch (Exception err) {
                    Console.WriteLine(err.Message);
                }
            }

            changeProText("압축을 해제하는 중");
            ZipFile.ExtractToDirectory(tempLoc + "\\SR_Temp.zip", tempLoc + "\\SoundRequest");
            if (File.Exists(tempLoc + "\\SR_Temp.zip")) {
                try {
                    File.Delete(tempLoc + "\\SR_Temp.zip");
                } catch (Exception err) {
                    Console.WriteLine(err.Message);
                }
            }

            if (shortcut.Checked && Setting.shortcut != "") {
                changeProText("바로가기 생성중");
                string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                using (StreamWriter writer = new StreamWriter(deskDir + "\\SoundRequest.url")) {
                    string app = tempLoc + "\\SoundRequest\\" + Setting.shortcut;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                }
                using (StreamWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu) + "\\SoundRequest.url")) {
                    string app = tempLoc + "\\SoundRequest\\" + Setting.shortcut;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                }
            }

            Setting.inProgress = false;
            progressBar1.Visible = false;
            progressText.Visible = false;
            installText.Text = $"SoundRequest Prototype 최신버전({Setting.programVer})의 설치가 완료되었습니다!\n설치 프로그램을 마치려면 '마침' 버튼을 눌러 주세요.";
            installed = true;
            install.LabelText = "마침";
            install.Visible = true;
        }

        private void progressTextUpdate(object sender, DownloadProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            progressText.Text = e.ProgressPercentage.ToString();
            progressText.Left = progressBar1.Left + progressBar1.wLoc - progressText.Width / 2;
        }

        private void changeProText(string text) {
            progressText.Text = text;
            progressText.Left = progressBar1.Left + (progressBar1.Width - progressText.Width) / 2;
            Refresh();
        }

        private void Main_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Graphics graphics = e.Graphics;
            Point[] points = {
                new Point(-1, 220), new Point(-1, Height), new Point(300, Height)
            };
            Brush brush = new LinearGradientBrush(new Rectangle(points[0], new Size(300, 80)), Color.FromArgb(200 ,255, 108, 171), Color.FromArgb(200 ,115, 102, 255), 45f);
            graphics.FillPolygon(brush, points);
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

        private void minBox_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e) {
            Utils.mouseMove(Handle);
        }
    }
}