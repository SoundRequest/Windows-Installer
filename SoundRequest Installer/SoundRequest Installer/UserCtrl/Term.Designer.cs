namespace SoundRequest_Installer.UserCtrl {
    partial class Term {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.termBox = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mainPanel.Controls.Add(this.termBox);
            this.mainPanel.Controls.Add(this.textLabel);
            this.mainPanel.Location = new System.Drawing.Point(5, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(290, 50);
            this.mainPanel.TabIndex = 0;
            // 
            // termBox
            // 
            this.termBox.Image = global::SoundRequest_Installer.Properties.Resources.Term;
            this.termBox.Location = new System.Drawing.Point(240, 0);
            this.termBox.Name = "termBox";
            this.termBox.Size = new System.Drawing.Size(50, 50);
            this.termBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.termBox.TabIndex = 0;
            this.termBox.TabStop = false;
            this.termBox.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.ForeColor = System.Drawing.Color.White;
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(290, 50);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "textLabel";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLabel.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // Term
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Term";
            this.Size = new System.Drawing.Size(300, 60);
            this.Click += new System.EventHandler(this.textLabel_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Term_Paint);
            this.Resize += new System.EventHandler(this.Term_Resize);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.termBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox termBox;
        private System.Windows.Forms.Label textLabel;
    }
}
