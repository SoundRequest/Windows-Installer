using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SoundRequest_Installer {
    public partial class SideBar : UserControl {

        private int tab = 5;
        private int index = 0;

        [Category("User")]
        public int Tab {
            get { return tab; }
            set {
                tab = value;
                update();
            }
        }

        public int Index {
            get { return index; }
            set {
                if (value > tab - 1)
                    index = tab - 1;
                else
                    index = value;
                update();
            }
        }

        public SideBar() {
            InitializeComponent();
            
        }

        private void update() {
            sidePanel.Size = new Size(Width - 8, Height - 8);
            sidePanel.Location = new Point(4, 4);
            tabPanel.Size = new Size(Width - 8, sidePanel.Height / tab);
            tabPanel.Location = new Point(0, sidePanel.Height / tab * index);
            Utils.smoothBorder(sidePanel, sidePanel.Width);
            Utils.smoothBorder(tabPanel, tabPanel.Width);
            tabPanel.Refresh();
        }

        private void tabPanel_Paint(object sender, PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, -sidePanel.Height / tab * index, sidePanel.Width, sidePanel.Height);
            Brush brush = new LinearGradientBrush(rectangle, Color.FromArgb(255, 108, 171), Color.FromArgb(115, 102, 255), 65f);
            graphics.FillRectangle(brush, rectangle);
        }

        private void SideBar_Resize(object sender, EventArgs e) {
            update();
        }
    }
}
