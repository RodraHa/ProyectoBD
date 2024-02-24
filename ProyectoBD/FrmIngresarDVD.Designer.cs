namespace ProyectoBD
{
    partial class FrmIngresarDVD
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPeliculas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chckTienda2 = new System.Windows.Forms.CheckBox();
            this.chckTienda1 = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelPelicula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(29, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 25);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPelicula.Location = new System.Drawing.Point(29, 32);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(158, 25);
            this.txtTituloPelicula.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Título";
            // 
            // lstPeliculas
            // 
            this.lstPeliculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPeliculas.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPeliculas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPeliculas.HideSelection = false;
            this.lstPeliculas.Location = new System.Drawing.Point(29, 115);
            this.lstPeliculas.MultiSelect = false;
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(323, 187);
            this.lstPeliculas.TabIndex = 4;
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
            // chckTienda2
            // 
            this.chckTienda2.AutoSize = true;
            this.chckTienda2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda2.Location = new System.Drawing.Point(497, 187);
            this.chckTienda2.Name = "chckTienda2";
            this.chckTienda2.Size = new System.Drawing.Size(77, 21);
            this.chckTienda2.TabIndex = 13;
            this.chckTienda2.Text = "Tienda 2";
            this.chckTienda2.UseVisualStyleBackColor = true;
            this.chckTienda2.CheckedChanged += new System.EventHandler(this.chckTienda2_CheckedChanged);
            // 
            // chckTienda1
            // 
            this.chckTienda1.AutoSize = true;
            this.chckTienda1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda1.Location = new System.Drawing.Point(497, 163);
            this.chckTienda1.Name = "chckTienda1";
            this.chckTienda1.Size = new System.Drawing.Size(77, 21);
            this.chckTienda1.TabIndex = 12;
            this.chckTienda1.Text = "Tienda 1";
            this.chckTienda1.UseVisualStyleBackColor = true;
            this.chckTienda1.CheckedChanged += new System.EventHandler(this.chckTienda1_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(489, 247);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 30);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelicula.Location = new System.Drawing.Point(489, 115);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(0, 17);
            this.labelPelicula.TabIndex = 16;
            // 
            // FrmIngresarDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 352);
            this.Controls.Add(this.labelPelicula);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.chckTienda2);
            this.Controls.Add(this.chckTienda1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPeliculas);
            this.Name = "FrmIngresarDVD";
            this.Text = "Ingresar DVD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIngresarDVD_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstPeliculas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox chckTienda2;
        private System.Windows.Forms.CheckBox chckTienda1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label labelPelicula;
    }
}