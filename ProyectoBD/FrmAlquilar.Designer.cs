namespace ProyectoBD
{
    partial class FrmAlquilar
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
            this.lstPeliculas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmBoxGeneros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeliculaInformacion = new System.Windows.Forms.Label();
            this.txtFechaPelicula = new System.Windows.Forms.Label();
            this.txtIdioma = new System.Windows.Forms.Label();
            this.txtCostoSustitucion = new System.Windows.Forms.Label();
            this.chckTienda1 = new System.Windows.Forms.CheckBox();
            this.chckTienda2 = new System.Windows.Forms.CheckBox();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPeliculas.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPeliculas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPeliculas.HideSelection = false;
            this.lstPeliculas.Location = new System.Drawing.Point(33, 120);
            this.lstPeliculas.MultiSelect = false;
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(323, 187);
            this.lstPeliculas.TabIndex = 0;
            this.lstPeliculas.UseCompatibleStateImageBehavior = false;
            this.lstPeliculas.View = System.Windows.Forms.View.Details;
            this.lstPeliculas.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstPeliculas_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Título";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Número de existencias";
            this.columnHeader2.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPelicula.Location = new System.Drawing.Point(33, 37);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(158, 25);
            this.txtTituloPelicula.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(33, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmBoxGeneros
            // 
            this.cmBoxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxGeneros.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxGeneros.FormattingEnabled = true;
            this.cmBoxGeneros.Location = new System.Drawing.Point(235, 37);
            this.cmBoxGeneros.Name = "cmBoxGeneros";
            this.cmBoxGeneros.Size = new System.Drawing.Size(121, 25);
            this.cmBoxGeneros.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Género";
            // 
            // txtPeliculaInformacion
            // 
            this.txtPeliculaInformacion.AutoSize = true;
            this.txtPeliculaInformacion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeliculaInformacion.Location = new System.Drawing.Point(437, 37);
            this.txtPeliculaInformacion.Name = "txtPeliculaInformacion";
            this.txtPeliculaInformacion.Size = new System.Drawing.Size(58, 17);
            this.txtPeliculaInformacion.TabIndex = 6;
            this.txtPeliculaInformacion.Text = "Película: ";
            // 
            // txtFechaPelicula
            // 
            this.txtFechaPelicula.AutoSize = true;
            this.txtFechaPelicula.CausesValidation = false;
            this.txtFechaPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaPelicula.Location = new System.Drawing.Point(437, 69);
            this.txtFechaPelicula.Name = "txtFechaPelicula";
            this.txtFechaPelicula.Size = new System.Drawing.Size(141, 17);
            this.txtFechaPelicula.TabIndex = 7;
            this.txtFechaPelicula.Text = "Fecha de lanzamiento: ";
            // 
            // txtIdioma
            // 
            this.txtIdioma.AutoSize = true;
            this.txtIdioma.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdioma.Location = new System.Drawing.Point(437, 101);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(55, 17);
            this.txtIdioma.TabIndex = 8;
            this.txtIdioma.Text = "Idioma: ";
            // 
            // txtCostoSustitucion
            // 
            this.txtCostoSustitucion.AutoSize = true;
            this.txtCostoSustitucion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoSustitucion.Location = new System.Drawing.Point(437, 133);
            this.txtCostoSustitucion.Name = "txtCostoSustitucion";
            this.txtCostoSustitucion.Size = new System.Drawing.Size(133, 17);
            this.txtCostoSustitucion.TabIndex = 9;
            this.txtCostoSustitucion.Text = "Costo de sustitución: ";
            // 
            // chckTienda1
            // 
            this.chckTienda1.AutoSize = true;
            this.chckTienda1.Enabled = false;
            this.chckTienda1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda1.Location = new System.Drawing.Point(440, 181);
            this.chckTienda1.Name = "chckTienda1";
            this.chckTienda1.Size = new System.Drawing.Size(77, 21);
            this.chckTienda1.TabIndex = 10;
            this.chckTienda1.Text = "Tienda 1";
            this.chckTienda1.UseVisualStyleBackColor = true;
            this.chckTienda1.CheckedChanged += new System.EventHandler(this.chckTienda1_CheckedChanged);
            // 
            // chckTienda2
            // 
            this.chckTienda2.AutoSize = true;
            this.chckTienda2.Enabled = false;
            this.chckTienda2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda2.Location = new System.Drawing.Point(440, 205);
            this.chckTienda2.Name = "chckTienda2";
            this.chckTienda2.Size = new System.Drawing.Size(77, 21);
            this.chckTienda2.TabIndex = 11;
            this.chckTienda2.Text = "Tienda 2";
            this.chckTienda2.UseVisualStyleBackColor = true;
            this.chckTienda2.CheckedChanged += new System.EventHandler(this.chckTienda2_CheckedChanged);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlquilar.Location = new System.Drawing.Point(440, 276);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(130, 31);
            this.btnAlquilar.TabIndex = 13;
            this.btnAlquilar.Text = "Alquilar DVD";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // FrmAlquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.chckTienda2);
            this.Controls.Add(this.chckTienda1);
            this.Controls.Add(this.txtCostoSustitucion);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtFechaPelicula);
            this.Controls.Add(this.txtPeliculaInformacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxGeneros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPeliculas);
            this.Name = "FrmAlquilar";
            this.Text = "Alquilar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAlquilar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPeliculas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmBoxGeneros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtPeliculaInformacion;
        private System.Windows.Forms.Label txtFechaPelicula;
        private System.Windows.Forms.Label txtIdioma;
        private System.Windows.Forms.Label txtCostoSustitucion;
        private System.Windows.Forms.CheckBox chckTienda1;
        private System.Windows.Forms.CheckBox chckTienda2;
        private System.Windows.Forms.Button btnAlquilar;
    }
}