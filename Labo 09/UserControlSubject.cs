using System;
using System.Windows.Forms;
using Laboratorio_09;

namespace Labo_09
{
    public partial class UserControlSubject : UserControl
    {
        public UserControlSubject()
        {
            InitializeComponent();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar el campo vacio");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"INSERT INTO MATERIA (nombre) VALUES (" +
                                                 $"'{textBoxSubject.Text}')");
                    MessageBox.Show("Se ha agregado la materia exitosamente");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}