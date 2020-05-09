namespace Labo_07
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Lblpush = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnHTML = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Lblpush, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRed, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnBlue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnGreen, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRestart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOptions, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnHTML, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.77004F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.449868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.450011F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00004F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lblpush
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Lblpush, 3);
            this.Lblpush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lblpush.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Lblpush.Location = new System.Drawing.Point(3, 0);
            this.Lblpush.Name = "Lblpush";
            this.Lblpush.Size = new System.Drawing.Size(446, 116);
            this.Lblpush.TabIndex = 0;
            this.Lblpush.Text = "Presiona un botón";
            this.Lblpush.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.White;
            this.btnRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRed.Location = new System.Drawing.Point(3, 264);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(144, 82);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Rojo";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.White;
            this.btnBlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBlue.Location = new System.Drawing.Point(153, 264);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(144, 82);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "Azul";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.White;
            this.btnGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGreen.Location = new System.Drawing.Point(303, 264);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(146, 82);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Text = "Verde";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRestart, 3);
            this.btnRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRestart.Location = new System.Drawing.Point(3, 119);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(446, 87);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Reiniciar a color principal";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtColor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtColor, 2);
            this.txtColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtColor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtColor.Location = new System.Drawing.Point(3, 212);
            this.txtColor.MaxLength = 6;
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(294, 20);
            this.txtColor.TabIndex = 4;
            this.txtColor.Text = "Ex: 000000";
            this.txtColor.Click += new System.EventHandler(this.txtColor_Click);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave_1);
            // 
            // comboBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 2);
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.White;
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptions.Location = new System.Drawing.Point(300, 235);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(152, 26);
            this.btnOptions.TabIndex = 10;
            this.btnOptions.Text = "Color opciones";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnHTML
            // 
            this.btnHTML.BackColor = System.Drawing.Color.White;
            this.btnHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHTML.Location = new System.Drawing.Point(300, 209);
            this.btnHTML.Margin = new System.Windows.Forms.Padding(0);
            this.btnHTML.Name = "btnHTML";
            this.btnHTML.Size = new System.Drawing.Size(152, 26);
            this.btnHTML.TabIndex = 11;
            this.btnHTML.Text = "Color HTML";
            this.btnHTML.UseVisualStyleBackColor = false;
            this.btnHTML.Click += new System.EventHandler(this.btnHTML_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change colors";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnHTML;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Lblpush;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtColor;

        #endregion
    }
}