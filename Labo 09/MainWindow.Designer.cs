namespace Labo_09
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutMainWindow = new System.Windows.Forms.TableLayoutPanel();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.userControlStudent1 = new Labo_09.UserControlStudent();
            this.tableLayoutMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutMainWindow
            // 
            this.tableLayoutMainWindow.ColumnCount = 4;
            this.tableLayoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMainWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutMainWindow.Controls.Add(this.btnEstudiante, 0, 0);
            this.tableLayoutMainWindow.Controls.Add(this.btnMateria, 1, 0);
            this.tableLayoutMainWindow.Controls.Add(this.btnInscripcion, 2, 0);
            this.tableLayoutMainWindow.Controls.Add(this.btnConsultar, 3, 0);
            this.tableLayoutMainWindow.Controls.Add(this.userControlStudent1, 0, 1);
            this.tableLayoutMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMainWindow.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMainWindow.Name = "tableLayoutMainWindow";
            this.tableLayoutMainWindow.RowCount = 2;
            this.tableLayoutMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutMainWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutMainWindow.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutMainWindow.TabIndex = 0;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstudiante.Location = new System.Drawing.Point(3, 3);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(194, 84);
            this.btnEstudiante.TabIndex = 0;
            this.btnEstudiante.Text = "Estudiante\r\n";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMateria.Location = new System.Drawing.Point(203, 3);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(194, 84);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscripcion.Location = new System.Drawing.Point(403, 3);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(194, 84);
            this.btnInscripcion.TabIndex = 2;
            this.btnInscripcion.Text = "Inscripcion";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultar.Location = new System.Drawing.Point(603, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(194, 84);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // userControlStudent1
            // 
            this.userControlStudent1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutMainWindow.SetColumnSpan(this.userControlStudent1, 4);
            this.userControlStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStudent1.Location = new System.Drawing.Point(3, 93);
            this.userControlStudent1.Name = "userControlStudent1";
            this.userControlStudent1.Size = new System.Drawing.Size(794, 354);
            this.userControlStudent1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutMainWindow);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Sistema de Control de Inscripciones";
            this.tableLayoutMainWindow.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMainWindow;
        private Labo_09.UserControlStudent userControlStudent1;

        #endregion
    }
}