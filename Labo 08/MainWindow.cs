using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_08
{
    public partial class MainWindow : Form
    {
        private UserControl current;
        private Register rg = new Register();
        public MainWindow()
        {
            InitializeComponent();
            current = login1;
            DoubleBuffered = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(current!=login1){
                tableLayoutMainWindow.Controls.Remove(current);
                current = login1;
                tableLayoutMainWindow.Controls.Add(current, 1,0);
                tableLayoutMainWindow.SetRowSpan(current,4);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(current!=rg){
                        tableLayoutMainWindow.Controls.Remove(current);
                        current = rg;
                        rg.Dock = DockStyle.Fill;
                        tableLayoutMainWindow.Controls.Add(current, 1,0);
                        tableLayoutMainWindow.SetRowSpan(current,4);
            }
        }
    }
}