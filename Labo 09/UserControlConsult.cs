using System;
using System.Windows.Forms;
using Laboratorio_09;

namespace Labo_09
{
    public partial class UserControlConsult : UserControl
    {
        public UserControlConsult()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (textBoxCarneConsult.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar el campo vacio");
            }
            else
            {
                try
                {
                    var dt = ConnectionBD.ExecuteQuery("SELECT ins.idMateria, mat.nombre " +
                                                       "FROM MATERIA mat, INSCRIPCION ins, ESTUDIANTE est " +
                                                       "WHERE ins.idMateria = mat.idMateria AND ins.carnet  = est.carnet " +
                                                       $"AND est.carnet = '{textBoxCarneConsult.Text}'"); 
                    dataGridViewConsult.DataSource = dt;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}