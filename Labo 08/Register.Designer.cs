using System.ComponentModel;

namespace Labo_08
{
    partial class Register
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
            this.tableLayoutRegister = new System.Windows.Forms.TableLayoutPanel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tableLayoutRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutRegister
            // 
            this.tableLayoutRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutRegister.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutRegister.ColumnCount = 1;
            this.tableLayoutRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRegister.Controls.Add(this.lblRegister, 0, 0);
            this.tableLayoutRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutRegister.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutRegister.Name = "tableLayoutRegister";
            this.tableLayoutRegister.RowCount = 1;
            this.tableLayoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutRegister.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutRegister.TabIndex = 0;
            // 
            // lblRegister
            // 
            this.lblRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblRegister.Location = new System.Drawing.Point(3, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(144, 150);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutRegister);
            this.Name = "Register";
            this.tableLayoutRegister.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TableLayoutPanel tableLayoutRegister;

        #endregion
    }
}