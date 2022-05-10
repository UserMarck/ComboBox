namespace ColorComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rjComboBox2 = new ColorComboBox.RJControl.RJComboBox();
            this.rjComboBox1 = new ColorComboBox.RJControl.RJComboBox();
            this.SuspendLayout();
            // 
            // rjComboBox2
            // 
            this.rjComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rjComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.rjComboBox2.BackColor = System.Drawing.Color.Ivory;
            this.rjComboBox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.rjComboBox2.BorderSize = 1;
            this.rjComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.IconColor = System.Drawing.Color.DarkGreen;
            this.rjComboBox2.Items.AddRange(new object[] {
            "gato",
            "perico",
            "tusa",
            "xd"});
            this.rjComboBox2.ListBackColor = System.Drawing.Color.Honeydew;
            this.rjComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.Location = new System.Drawing.Point(294, 62);
            this.rjComboBox2.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox2.Name = "rjComboBox2";
            this.rjComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox2.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox2.TabIndex = 1;
            this.rjComboBox2.Texts = "";
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(61, 62);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox1.TabIndex = 0;
            this.rjComboBox1.Texts = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rjComboBox2);
            this.Controls.Add(this.rjComboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RJControl.RJComboBox rjComboBox1;
        private RJControl.RJComboBox rjComboBox2;
    }
}

