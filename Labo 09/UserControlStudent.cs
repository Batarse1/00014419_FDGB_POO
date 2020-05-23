using System;
using System.Windows.Forms;
using Laboratorio_09;

namespace Labo_09
{
    public partial class UserControlStudent : UserControl
    {
        public UserControlStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals("") ||
                textBoxLastName.Text.Equals("") ||
                textBoxCarne.Text.Equals("") ||
                textBoxAge.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO ESTUDIANTE VALUES (" +
                                                 $"'{textBoxCarne.Text}'," +
                                                 $"'{textBoxName.Text}'," +
                                                 $"'{textBoxLastName.Text}'," +
                                                 $"{textBoxAge.Text})");
                    MessageBox.Show("Se ha agregado el estudiante exitosamente");
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}