using System.ComponentModel;

namespace Labo_09
{
    partial class UserControlInscription
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
            this.tableLayoutInscription = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubjectInscription = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.lblCarneInscription = new System.Windows.Forms.Label();
            this.textBoxCarne = new System.Windows.Forms.TextBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.tableLayoutInscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutInscription
            // 
            this.tableLayoutInscription.ColumnCount = 4;
            this.tableLayoutInscription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutInscription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutInscription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutInscription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutInscription.Controls.Add(this.lblSubjectInscription, 0, 3);
            this.tableLayoutInscription.Controls.Add(this.btnInscription, 0, 6);
            this.tableLayoutInscription.Controls.Add(this.lblCarneInscription, 0, 0);
            this.tableLayoutInscription.Controls.Add(this.textBoxCarne, 2, 1);
            this.tableLayoutInscription.Controls.Add(this.comboBoxSubject, 2, 4);
            this.tableLayoutInscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutInscription.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutInscription.Name = "tableLayoutInscription";
            this.tableLayoutInscription.RowCount = 7;
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66019F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.000064F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.77987F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.15094F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.329195F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.66006F));
            this.tableLayoutInscription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03012F));
            this.tableLayoutInscription.Size = new System.Drawing.Size(597, 474);
            this.tableLayoutInscription.TabIndex = 0;
            // 
            // lblSubjectInscription
            // 
            this.lblSubjectInscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubjectInscription.Location = new System.Drawing.Point(3, 162);
            this.lblSubjectInscription.Name = "lblSubjectInscription";
            this.tableLayoutInscription.SetRowSpan(this.lblSubjectInscription, 3);
            this.lblSubjectInscription.Size = new System.Drawing.Size(113, 166);
            this.lblSubjectInscription.TabIndex = 0;
            this.lblSubjectInscription.Text = "Materia";
            this.lblSubjectInscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInscription
            // 
            this.tableLayoutInscription.SetColumnSpan(this.btnInscription, 4);
            this.btnInscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscription.Location = new System.Drawing.Point(3, 331);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(591, 140);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "Inscribir Materia";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // lblCarneInscription
            // 
            this.lblCarneInscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarneInscription.Location = new System.Drawing.Point(3, 0);
            this.lblCarneInscription.Name = "lblCarneInscription";
            this.tableLayoutInscription.SetRowSpan(this.lblCarneInscription, 3);
            this.lblCarneInscription.Size = new System.Drawing.Size(113, 162);
            this.lblCarneInscription.TabIndex = 2;
            this.lblCarneInscription.Text = "Carne";
            this.lblCarneInscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCarne
            // 
            this.textBoxCarne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCarne.Location = new System.Drawing.Point(151, 72);
            this.textBoxCarne.Name = "textBoxCarne";
            this.textBoxCarne.Size = new System.Drawing.Size(411, 22);
            this.textBoxCarne.TabIndex = 3;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(151, 232);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(411, 24);
            this.comboBoxSubject.TabIndex = 4;
            // 
            // UserControlInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutInscription);
            this.Name = "UserControlInscription";
            this.Size = new System.Drawing.Size(597, 474);
            this.Load += new System.EventHandler(this.UserControlInscription_Load);
            this.tableLayoutInscription.ResumeLayout(false);
            this.tableLayoutInscription.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.Label lblCarneInscription;
        private System.Windows.Forms.Label lblSubjectInscription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInscription;
        private System.Windows.Forms.TextBox textBoxCarne;

        #endregion
    }
}