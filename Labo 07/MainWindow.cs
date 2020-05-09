using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_07
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<String>(){"Morado","Celeste","Rosado"};
        }
        private void btnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.GradientActiveCaption;
        }
        private void btnOptions_Click(object sender, EventArgs e)
        {
            String morado = "#7d4ebf", celeste = "#45dbe6", rosado = "#e241e8";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    BackColor = ColorTranslator.FromHtml(morado);                
                    break;                
                case 1:
                    BackColor = ColorTranslator.FromHtml(celeste);                
                    break;
                case 2:
                    BackColor = ColorTranslator.FromHtml(rosado);                
                    break;
            }
        }
        private void btnHTML_Click(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#" + txtColor.Text);
        }
        private void txtColor_Click(object sender, EventArgs e)
        {
            txtColor.Clear();
            txtColor.ForeColor = SystemColors.WindowText;
        }
        private void txtColor_Leave_1(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Ex: 000000";
                txtColor.ForeColor = SystemColors.GrayText;
            }
        }
    }
}