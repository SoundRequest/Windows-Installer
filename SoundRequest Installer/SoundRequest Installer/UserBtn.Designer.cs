﻿namespace SoundRequest_Installer {
    partial class UserBtn {
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
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(120, 60);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "text";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textLabel_MouseClick);
            this.textLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textLabel_MouseClick);
            // 
            // UserBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserBtn";
            this.Size = new System.Drawing.Size(120, 60);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserBtn_Paint);
            this.Resize += new System.EventHandler(this.UserBtn_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
    }
}
