namespace SoundRequest_Installer {
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.coverPanel = new System.Windows.Forms.Panel();
            this.closeLoaderBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new SoundRequest_Installer.UserBtn();
            this.nextBtn = new SoundRequest_Installer.UserBtn();
            this.stepBar = new SoundRequest_Installer.SideBar();
            this.term1 = new SoundRequest_Installer.UserCtrl.Term();
            this.term2 = new SoundRequest_Installer.UserCtrl.Term();
            this.coverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoaderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            this.mainFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(38, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(334, 40);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "SoundRequest Installer";
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
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
            // coverPanel
            // 
            this.coverPanel.Controls.Add(this.closeLoaderBox);
            this.coverPanel.Controls.Add(this.infoLabel);
            this.coverPanel.Controls.Add(this.statusLabel);
            this.coverPanel.Location = new System.Drawing.Point(75, 371);
            this.coverPanel.Name = "coverPanel";
            this.coverPanel.Size = new System.Drawing.Size(186, 122);
            this.coverPanel.TabIndex = 11;
            this.coverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // closeLoaderBox
            // 
            this.closeLoaderBox.Image = global::SoundRequest_Installer.Properties.Resources.Close;
            this.closeLoaderBox.Location = new System.Drawing.Point(140, 3);
            this.closeLoaderBox.Name = "closeLoaderBox";
            this.closeLoaderBox.Size = new System.Drawing.Size(20, 20);
            this.closeLoaderBox.TabIndex = 12;
            this.closeLoaderBox.TabStop = false;
            this.closeLoaderBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeLoaderBox.DoubleClick += new System.EventHandler(this.closeBox_Click);
            // 
            // closeBox
            // 
            this.closeBox.Image = global::SoundRequest_Installer.Properties.Resources.Close;
            this.closeBox.Location = new System.Drawing.Point(618, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(20, 20);
            this.closeBox.TabIndex = 6;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // minBox
            // 
            this.minBox.Image = global::SoundRequest_Installer.Properties.Resources.Min;
            this.minBox.Location = new System.Drawing.Point(592, 12);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(20, 20);
            this.minBox.TabIndex = 5;
            this.minBox.TabStop = false;
            this.minBox.Click += new System.EventHandler(this.minBox_Click);
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.Controls.Add(this.term1);
            this.mainFlowPanel.Controls.Add(this.term2);
            this.mainFlowPanel.Location = new System.Drawing.Point(62, 65);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(550, 270);
            this.mainFlowPanel.TabIndex = 12;
            this.mainFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainFlowPanel_Paint);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.LabelText = "뒤로";
            this.backBtn.Location = new System.Drawing.Point(452, 348);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(90, 40);
            this.backBtn.TabIndex = 8;
            this.backBtn.OnClick += new System.EventHandler(this.backBtn_OnClick);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.LabelText = "다음";
            this.nextBtn.Location = new System.Drawing.Point(548, 348);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(90, 40);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.OnClick += new System.EventHandler(this.nextBtn_OnClick);
            // 
            // stepBar
            // 
            this.stepBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepBar.Index = 0;
            this.stepBar.Location = new System.Drawing.Point(12, 12);
            this.stepBar.Name = "stepBar";
            this.stepBar.Size = new System.Drawing.Size(20, 376);
            this.stepBar.Tab = 5;
            this.stepBar.TabIndex = 0;
            this.stepBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // term1
            // 
            this.term1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term1.LabelText = "이용약관";
            this.term1.Location = new System.Drawing.Point(3, 3);
            this.term1.Name = "term1";
            this.term1.Size = new System.Drawing.Size(340, 50);
            this.term1.TabIndex = 0;
            this.term1.URL = null;
            // 
            // term2
            // 
            this.term2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.term2.LabelText = "개인정보처리방침";
            this.term2.Location = new System.Drawing.Point(3, 59);
            this.term2.Name = "term2";
            this.term2.Size = new System.Drawing.Size(340, 50);
            this.term2.TabIndex = 1;
            this.term2.URL = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.coverPanel);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.stepBar);
            this.Controls.Add(this.mainFlowPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "SoundRequest";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.coverPanel.ResumeLayout(false);
            this.coverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeLoaderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            this.mainFlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SideBar stepBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox minBox;
        private System.Windows.Forms.PictureBox closeBox;
        private UserBtn nextBtn;
        private UserBtn backBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel coverPanel;
        private System.Windows.Forms.PictureBox closeLoaderBox;
        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private UserCtrl.Term term1;
        private UserCtrl.Term term2;
    }
}

