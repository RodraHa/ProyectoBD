namespace ProyectoBD
{
    partial class FrmIngresarPelicula
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.txtFechaLanzamiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxIdioma = new System.Windows.Forms.ComboBox();
            this.precioUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.costoReemplazoUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnIngresarPelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.precioUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoReemplazoUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título de la película";
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPelicula.Location = new System.Drawing.Point(192, 60);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(182, 25);
            this.txtTituloPelicula.TabIndex = 1;
            // 
            // txtFechaLanzamiento
            // 
            this.txtFechaLanzamiento.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaLanzamiento.Location = new System.Drawing.Point(100, 137);
            this.txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            this.txtFechaLanzamiento.Size = new System.Drawing.Size(100, 25);
            this.txtFechaLanzamiento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de lanzamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idioma";
            // 
            // cmbBoxIdioma
            // 
            this.cmbBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxIdioma.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxIdioma.FormattingEnabled = true;
            this.cmbBoxIdioma.Location = new System.Drawing.Point(100, 204);
            this.cmbBoxIdioma.Name = "cmbBoxIdioma";
            this.cmbBoxIdioma.Size = new System.Drawing.Size(121, 25);
            this.cmbBoxIdioma.TabIndex = 5;
            // 
            // precioUpDown
            // 
            this.precioUpDown.DecimalPlaces = 2;
            this.precioUpDown.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioUpDown.Location = new System.Drawing.Point(331, 141);
            this.precioUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.precioUpDown.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.precioUpDown.Name = "precioUpDown";
            this.precioUpDown.ReadOnly = true;
            this.precioUpDown.Size = new System.Drawing.Size(120, 25);
            this.precioUpDown.TabIndex = 6;
            this.precioUpDown.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio de alquiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo de reemplazo";
            // 
            // costoReemplazoUpDown
            // 
            this.costoReemplazoUpDown.DecimalPlaces = 2;
            this.costoReemplazoUpDown.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoReemplazoUpDown.Location = new System.Drawing.Point(331, 202);
            this.costoReemplazoUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.costoReemplazoUpDown.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.costoReemplazoUpDown.Name = "costoReemplazoUpDown";
            this.costoReemplazoUpDown.ReadOnly = true;
            this.costoReemplazoUpDown.Size = new System.Drawing.Size(120, 25);
            this.costoReemplazoUpDown.TabIndex = 9;
            this.costoReemplazoUpDown.Value = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            // 
            // btnIngresarPelicula
            // 
            this.btnIngresarPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPelicula.Location = new System.Drawing.Point(234, 273);
            this.btnIngresarPelicula.Name = "btnIngresarPelicula";
            this.btnIngresarPelicula.Size = new System.Drawing.Size(89, 34);
            this.btnIngresarPelicula.TabIndex = 10;
            this.btnIngresarPelicula.Text = "Ingresar";
            this.btnIngresarPelicula.UseVisualStyleBackColor = true;
            this.btnIngresarPelicula.Click += new System.EventHandler(this.btnIngresarPelicula_Click);
            // 
            // FrmIngresarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnIngresarPelicula);
            this.Controls.Add(this.costoReemplazoUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioUpDown);
            this.Controls.Add(this.cmbBoxIdioma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFechaLanzamiento);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.label1);
            this.Name = "FrmIngresarPelicula";
            this.Text = "Ingresar Pelicula";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIngresarPelicula_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.precioUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoReemplazoUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.TextBox txtFechaLanzamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxIdioma;
        private System.Windows.Forms.NumericUpDown precioUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown costoReemplazoUpDown;
        private System.Windows.Forms.Button btnIngresarPelicula;
    }
}