using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Laboratorio_09;

namespace Labo_09
{
    public partial class UserControlInscription : UserControl
    {
        public UserControlInscription()
        {
            InitializeComponent();
        }

        private void UserControlInscription_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            var subjects = ConnectionBD.ExecuteQuery("SELECT nombre FROM materia");
            var subjectsCombo = new List<string>();
            foreach (DataRow dr in subjects.Rows)
            {
                subjectsCombo.Add(dr[0].ToString());
            }
            comboBoxSubject.DataSource = subjectsCombo;
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            if (textBoxCarne.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar el campo vacio");
            }
            else
            {
                try
                {
                    string query = $"SELECT idMateria FROM materia WHERE nombre = '{comboBoxSubject.SelectedItem.ToString()}'";
                    var dt = ConnectionBD.ExecuteQuery(query);
                    var dr = dt.Rows[0];
                    var idMateria = Convert.ToInt32(dr[0].ToString());
                    string nonquery = $"INSERT INTO INSCRIPCION (idMateria, carnet) VALUES ("+
                           $"{idMateria},"+ 
                           $"'{textBoxCarne.Text}')";
                    ConnectionBD.ExecuteNonQuery(nonquery);
                    MessageBox.Show("Se ha inscrito la materia");
                }
                catch(Exception exc){
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}