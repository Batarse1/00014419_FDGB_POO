using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo_09
{
  public partial class MainWindow : Form
  {
    private UserControl current = null;
    public MainWindow()
    {
      InitializeComponent();
      current = userControlStudent1;
    }

    private void btnEstudiante_Click(object sender, EventArgs e)
    {
      if (!(current is UserControlStudent))
      {
        tableLayoutMainWindow.Controls.Remove(current);
        current = new UserControlStudent();
        current.Dock = DockStyle.Fill;
        tableLayoutMainWindow.Controls.Add(current, 0,1);
        tableLayoutMainWindow.SetColumnSpan(current, 4);
      }
    }

    private void btnMateria_Click(object sender, EventArgs e)
    {
      if (!(current is UserControlSubject))
      {
        tableLayoutMainWindow.Controls.Remove(current);
        current = new UserControlSubject();
        current.Dock = DockStyle.Fill;
        tableLayoutMainWindow.Controls.Add(current, 0,1);
        tableLayoutMainWindow.SetColumnSpan(current, 4);
      }
    }

    private void btnInscripcion_Click(object sender, EventArgs e)
    {
      if (!(current is UserControlInscription))
      {
        tableLayoutMainWindow.Controls.Remove(current);
        current = new UserControlInscription();
        current.Dock = DockStyle.Fill;
        tableLayoutMainWindow.Controls.Add(current, 0,1);
        tableLayoutMainWindow.SetColumnSpan(current, 4);
      }
    }

    private void btnConsultar_Click(object sender, EventArgs e)
    {
      if (!(current is UserControlConsult))
      {
        tableLayoutMainWindow.Controls.Remove(current);
        current = new UserControlConsult();
        current.Dock = DockStyle.Fill;
        tableLayoutMainWindow.Controls.Add(current, 0,1);
        tableLayoutMainWindow.SetColumnSpan(current, 4);
      }
    }
  }
}
