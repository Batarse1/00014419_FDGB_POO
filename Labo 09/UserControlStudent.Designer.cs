using System.ComponentModel;

namespace Labo_09
{
    partial class UserControlStudent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutStudent = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblCarne = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarne = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.tableLayoutStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutStudent
            // 
            this.tableLayoutStudent.ColumnCount = 4;
            this.tableLayoutStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutStudent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutStudent.Controls.Add(this.textBoxName, 2, 1);
            this.tableLayoutStudent.Controls.Add(this.lblLastName, 0, 3);
            this.tableLayoutStudent.Controls.Add(this.textBoxLastName, 2, 4);
            this.tableLayoutStudent.Controls.Add(this.lblCarne, 0, 6);
            this.tableLayoutStudent.Controls.Add(this.btnAddStudent, 2, 11);
            this.tableLayoutStudent.Controls.Add(this.label1, 0, 9);
            this.tableLayoutStudent.Controls.Add(this.textBoxCarne, 2, 7);
            this.tableLayoutStudent.Controls.Add(this.textBoxAge, 2, 10);
            this.tableLayoutStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutStudent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutStudent.Name = "tableLayoutStudent";
            this.tableLayoutStudent.RowCount = 12;
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.880001F));
            this.tableLayoutStudent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.960001F));
            this.tableLayoutStudent.Size = new System.Drawing.Size(810, 593);
            this.tableLayoutStudent.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.tableLayoutStudent.SetRowSpan(this.lblName, 3);
            this.lblName.Size = new System.Drawing.Size(156, 133);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombres";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(205, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(561, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(3, 133);
            this.lblLastName.Name = "lblLastName";
            this.tableLayoutStudent.SetRowSpan(this.lblLastName, 3);
            this.lblLastName.Size = new System.Drawing.Size(156, 133);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellidos";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLastName.Location = new System.Drawing.Point(205, 188);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(561, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // lblCarne
            // 
            this.lblCarne.BackColor = System.Drawing.Color.Transparent;
            this.lblCarne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarne.Location = new System.Drawing.Point(3, 266);
            this.lblCarne.Name = "lblCarne";
            this.tableLayoutStudent.SetRowSpan(this.lblCarne, 3);
            this.lblCarne.Size = new System.Drawing.Size(156, 133);
            this.lblCarne.TabIndex = 5;
            this.lblCarne.Text = "Carnet";
            this.lblCarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddStudent
            // 
            this.tableLayoutStudent.SetColumnSpan(this.btnAddStudent, 4);
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStudent.Location = new System.Drawing.Point(3, 535);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(804, 55);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Agregar Estudiante";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 399);
            this.label1.Name = "label1";
            this.tableLayoutStudent.SetRowSpan(this.label1, 3);
            this.label1.Size = new System.Drawing.Size(156, 133);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCarne
            // 
            this.textBoxCarne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCarne.Location = new System.Drawing.Point(205, 321);
            this.textBoxCarne.Name = "textBoxCarne";
            this.textBoxCarne.Size = new System.Drawing.Size(561, 22);
            this.textBoxCarne.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAge.Location = new System.Drawing.Point(205, 454);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(561, 22);
            this.textBoxAge.TabIndex = 8;
            // 
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutStudent);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(810, 593);
            this.tableLayoutStudent.ResumeLayout(false);
            this.tableLayoutStudent.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStudent;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxCarne;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;

        #endregion
    }
}