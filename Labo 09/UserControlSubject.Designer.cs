using System.ComponentModel;

namespace Labo_09
{
    partial class UserControlSubject
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
            this.tableLayoutSubject = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.btnSubject = new System.Windows.Forms.Button();
            this.tableLayoutSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutSubject
            // 
            this.tableLayoutSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutSubject.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutSubject.ColumnCount = 4;
            this.tableLayoutSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutSubject.Controls.Add(this.lblSubject, 0, 0);
            this.tableLayoutSubject.Controls.Add(this.textBoxSubject, 2, 1);
            this.tableLayoutSubject.Controls.Add(this.btnSubject, 0, 3);
            this.tableLayoutSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutSubject.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutSubject.Name = "tableLayoutSubject";
            this.tableLayoutSubject.RowCount = 4;
            this.tableLayoutSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutSubject.Size = new System.Drawing.Size(711, 522);
            this.tableLayoutSubject.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubject.Location = new System.Drawing.Point(3, 0);
            this.lblSubject.Name = "lblSubject";
            this.tableLayoutSubject.SetRowSpan(this.lblSubject, 3);
            this.lblSubject.Size = new System.Drawing.Size(136, 364);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Materia";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSubject.Location = new System.Drawing.Point(180, 172);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(491, 22);
            this.textBoxSubject.TabIndex = 1;
            // 
            // btnSubject
            // 
            this.btnSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutSubject.SetColumnSpan(this.btnSubject, 4);
            this.btnSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubject.Location = new System.Drawing.Point(3, 367);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(705, 152);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Anadir Materia";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // UserControlSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutSubject);
            this.Name = "UserControlSubject";
            this.Size = new System.Drawing.Size(711, 522);
            this.tableLayoutSubject.ResumeLayout(false);
            this.tableLayoutSubject.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutSubject;
        private System.Windows.Forms.TextBox textBoxSubject;

        #endregion
    }
}