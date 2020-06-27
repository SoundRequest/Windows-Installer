using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundRequest_Installer {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            stepBar.Index += 1;
        }
    }
}
