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
            this.minBox = new System.Windows.Forms.PictureBox();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new SoundRequest_Installer.UserBtn();
            this.nextBtn = new SoundRequest_Installer.UserBtn();
            this.stepBar = new SoundRequest_Installer.SideBar();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
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
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.LabelText = "Back";
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
            this.nextBtn.LabelText = "Next";
            this.nextBtn.Location = new System.Drawing.Point(548, 348);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(90, 40);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.OnClick += new System.EventHandler(this.nextBtn_OnClick);
            this.nextBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.nextBtn_Paint);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.stepBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "SoundRequest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
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
    }
}

