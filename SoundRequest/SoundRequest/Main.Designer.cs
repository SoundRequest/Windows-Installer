namespace SoundRequest {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.coverPanel = new System.Windows.Forms.Panel();
            this.closeLoaderBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verText = new System.Windows.Forms.Label();
            this.installLoc = new System.Windows.Forms.TextBox();
            this.installText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGO = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.shortcut = new System.Windows.Forms.CheckBox();
            this.changeLoc = new SoundRequest.UserBtn();
            this.install = new SoundRequest.UserBtn();
            this.progressBar1 = new SoundRequest.Ctl.ProgressBar();
            this.progressText = new System.Windows.Forms.Label();
            this.coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoaderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            this.SuspendLayout();
            // 
            // coverPanel
            // 
            this.coverPanel.Controls.Add(this.closeLoaderBox);
            this.coverPanel.Controls.Add(this.infoLabel);
            this.coverPanel.Controls.Add(this.statusLabel);
            this.coverPanel.ForeColor = System.Drawing.Color.White;
            this.coverPanel.Location = new System.Drawing.Point(108, 262);
            this.coverPanel.Name = "coverPanel";
            this.coverPanel.Size = new System.Drawing.Size(159, 104);
            this.coverPanel.TabIndex = 12;
            this.coverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // closeLoaderBox
            // 
            this.closeLoaderBox.Image = global::SoundRequest.Properties.Resources.Close;
            this.closeLoaderBox.Location = new System.Drawing.Point(140, 3);
            this.closeLoaderBox.Name = "closeLoaderBox";
            this.closeLoaderBox.Size = new System.Drawing.Size(20, 20);
            this.closeLoaderBox.TabIndex = 12;
            this.closeLoaderBox.TabStop = false;
            this.closeLoaderBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeLoaderBox.DoubleClick += new System.EventHandler(this.closeBox_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(-47, 95);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(275, 42);
            this.infoLabel.TabIndex = 10;
            this.infoLabel.Text = "Loading updated data from the server.\r\nThis might take a few seconds.";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(-68, 21);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(325, 86);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "LOADING";
            this.statusLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "SoundRequest Installer";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // verText
            // 
            this.verText.AutoSize = true;
            this.verText.Location = new System.Drawing.Point(438, 278);
            this.verText.Name = "verText";
            this.verText.Size = new System.Drawing.Size(49, 13);
            this.verText.TabIndex = 14;
            this.verText.Text = "lastDate";
            this.verText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // installLoc
            // 
            this.installLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.installLoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.installLoc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installLoc.ForeColor = System.Drawing.Color.White;
            this.installLoc.Location = new System.Drawing.Point(26, 115);
            this.installLoc.Multiline = true;
            this.installLoc.Name = "installLoc";
            this.installLoc.Size = new System.Drawing.Size(350, 24);
            this.installLoc.TabIndex = 16;
            // 
            // installText
            // 
            this.installText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installText.Location = new System.Drawing.Point(23, 50);
            this.installText.Name = "installText";
            this.installText.Size = new System.Drawing.Size(450, 45);
            this.installText.TabIndex = 17;
            this.installText.Text = "text";
            this.installText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "설치 위치:";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // LOGO
            // 
            this.LOGO.Image = global::SoundRequest.Properties.Resources.SoundRequest_1700x1700_DEV;
            this.LOGO.Location = new System.Drawing.Point(11, 9);
            this.LOGO.Margin = new System.Windows.Forms.Padding(2);
            this.LOGO.Name = "LOGO";
            this.LOGO.Size = new System.Drawing.Size(25, 25);
            this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LOGO.TabIndex = 15;
            this.LOGO.TabStop = false;
            this.LOGO.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // closeBox
            // 
            this.closeBox.Image = global::SoundRequest.Properties.Resources.Close;
            this.closeBox.Location = new System.Drawing.Point(474, 6);
            this.closeBox.Margin = new System.Windows.Forms.Padding(2);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 8;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.DoubleClick += new System.EventHandler(this.closeBox_Click);
            // 
            // minBox
            // 
            this.minBox.Image = global::SoundRequest.Properties.Resources.Min;
            this.minBox.Location = new System.Drawing.Point(450, 6);
            this.minBox.Margin = new System.Windows.Forms.Padding(2);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(20, 20);
            this.minBox.TabIndex = 7;
            this.minBox.TabStop = false;
            this.minBox.Click += new System.EventHandler(this.minBox_Click);
            this.minBox.DoubleClick += new System.EventHandler(this.minBox_Click);
            // 
            // shortcut
            // 
            this.shortcut.AutoSize = true;
            this.shortcut.Checked = true;
            this.shortcut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shortcut.Location = new System.Drawing.Point(26, 145);
            this.shortcut.Name = "shortcut";
            this.shortcut.Size = new System.Drawing.Size(106, 17);
            this.shortcut.TabIndex = 21;
            this.shortcut.Text = "바로가기 만들기";
            this.shortcut.UseVisualStyleBackColor = true;
            // 
            // changeLoc
            // 
            this.changeLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLoc.LabelText = "변경";
            this.changeLoc.Location = new System.Drawing.Point(382, 115);
            this.changeLoc.Name = "changeLoc";
            this.changeLoc.Size = new System.Drawing.Size(69, 32);
            this.changeLoc.TabIndex = 19;
            this.changeLoc.OnClick += new System.EventHandler(this.changeLoc_OnClick);
            // 
            // install
            // 
            this.install.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.install.LabelText = "설치하기";
            this.install.Location = new System.Drawing.Point(331, 210);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(100, 45);
            this.install.TabIndex = 20;
            this.install.OnClick += new System.EventHandler(this.install_OnClick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.progressBar1.Location = new System.Drawing.Point(33, 188);
            this.progressBar1.Max = 100;
            this.progressBar1.Min = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 12);
            this.progressBar1.TabIndex = 22;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            this.progressBar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // progressText
            // 
            this.progressText.AutoSize = true;
            this.progressText.Location = new System.Drawing.Point(169, 213);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(13, 13);
            this.progressText.TabIndex = 23;
            this.progressText.Text = "P";
            this.progressText.Visible = false;
            this.progressText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LOGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coverPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.installText);
            this.Controls.Add(this.installLoc);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.verText);
            this.Controls.Add(this.changeLoc);
            this.Controls.Add(this.install);
            this.Controls.Add(this.shortcut);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SoundRequest Installer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.coverPanel.ResumeLayout(false);
            this.coverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoaderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBox;
        private System.Windows.Forms.PictureBox minBox;
        private System.Windows.Forms.Panel coverPanel;
        private System.Windows.Forms.PictureBox closeLoaderBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label verText;
        private System.Windows.Forms.PictureBox LOGO;
        private System.Windows.Forms.TextBox installLoc;
        private System.Windows.Forms.Label installText;
        private System.Windows.Forms.Label label2;
        private UserBtn changeLoc;
        private UserBtn install;
        private System.Windows.Forms.CheckBox shortcut;
        private Ctl.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressText;
    }
}

