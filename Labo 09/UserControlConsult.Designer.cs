using System.ComponentModel;

namespace Labo_09
{
    partial class UserControlConsult
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
            this.tableLayoutConsult = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCarneConsult = new System.Windows.Forms.TextBox();
            this.lblCarneConsult = new System.Windows.Forms.Label();
            this.btnConsult = new System.Windows.Forms.Button();
            this.dataGridViewConsult = new System.Windows.Forms.DataGridView();
            this.tableLayoutConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutConsult
            // 
            this.tableLayoutConsult.ColumnCount = 5;
            this.tableLayoutConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutConsult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutConsult.Controls.Add(this.textBoxCarneConsult, 2, 1);
            this.tableLayoutConsult.Controls.Add(this.lblCarneConsult, 0, 0);
            this.tableLayoutConsult.Controls.Add(this.btnConsult, 4, 0);
            this.tableLayoutConsult.Controls.Add(this.dataGridViewConsult, 0, 3);
            this.tableLayoutConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutConsult.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutConsult.Name = "tableLayoutConsult";
            this.tableLayoutConsult.RowCount = 4;
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutConsult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutConsult.Size = new System.Drawing.Size(429, 362);
            this.tableLayoutConsult.TabIndex = 0;
            // 
            // textBoxCarneConsult
            // 
            this.textBoxCarneConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCarneConsult.Location = new System.Drawing.Point(109, 39);
            this.textBoxCarneConsult.Name = "textBoxCarneConsult";
            this.textBoxCarneConsult.Size = new System.Drawing.Size(208, 22);
            this.textBoxCarneConsult.TabIndex = 0;
            // 
            // lblCarneConsult
            // 
            this.lblCarneConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarneConsult.Location = new System.Drawing.Point(3, 0);
            this.lblCarneConsult.Name = "lblCarneConsult";
            this.tableLayoutConsult.SetRowSpan(this.lblCarneConsult, 3);
            this.lblCarneConsult.Size = new System.Drawing.Size(79, 90);
            this.lblCarneConsult.TabIndex = 1;
            this.lblCarneConsult.Text = "Carne";
            this.lblCarneConsult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsult
            // 
            this.btnConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsult.Location = new System.Drawing.Point(344, 3);
            this.btnConsult.Name = "btnConsult";
            this.tableLayoutConsult.SetRowSpan(this.btnConsult, 3);
            this.btnConsult.Size = new System.Drawing.Size(82, 84);
            this.btnConsult.TabIndex = 2;
            this.btnConsult.Text = "Consultar";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // dataGridViewConsult
            // 
            this.dataGridViewConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutConsult.SetColumnSpan(this.dataGridViewConsult, 5);
            this.dataGridViewConsult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConsult.Location = new System.Drawing.Point(3, 93);
            this.dataGridViewConsult.Name = "dataGridViewConsult";
            this.dataGridViewConsult.RowTemplate.Height = 24;
            this.dataGridViewConsult.Size = new System.Drawing.Size(423, 266);
            this.dataGridViewConsult.TabIndex = 3;
            // 
            // UserControlConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutConsult);
            this.Name = "UserControlConsult";
            this.Size = new System.Drawing.Size(429, 362);
            this.tableLayoutConsult.ResumeLayout(false);
            this.tableLayoutConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewConsult)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.DataGridView dataGridViewConsult;
        private System.Windows.Forms.Label lblCarneConsult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutConsult;
        private System.Windows.Forms.TextBox textBoxCarneConsult;

        #endregion
    }
}