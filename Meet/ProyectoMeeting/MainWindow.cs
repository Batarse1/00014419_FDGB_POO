using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMeeting
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var players = new List<string>();
            var dt = connectionDB.ExecuteQuery(
                "SELECT NICKNAME FROM PLAYER"
            );

            foreach (DataRow row in dt.Rows)
            {
                players.Add(row[0].ToString());
            }

            comboBoxNickname.DataSource = players;
        }

    }
}