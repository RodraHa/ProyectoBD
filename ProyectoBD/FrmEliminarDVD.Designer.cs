namespace ProyectoBD
{
    partial class FrmEliminarDVD
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
            this.labelPelicula = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chckTienda2 = new System.Windows.Forms.CheckBox();
            this.chckTienda1 = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPeliculas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelPelicula
            // 
            this.labelPelicula.AutoSize = true;
            this.labelPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPelicula.Location = new System.Drawing.Point(488, 124);
            this.labelPelicula.Name = "labelPelicula";
            this.labelPelicula.Size = new System.Drawing.Size(0, 17);
            this.labelPelicula.TabIndex = 24;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(488, 256);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 30);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chckTienda2
            // 
            this.chckTienda2.AutoSize = true;
            this.chckTienda2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda2.Location = new System.Drawing.Point(448, 196);
            this.chckTienda2.Name = "chckTienda2";
            this.chckTienda2.Size = new System.Drawing.Size(77, 21);
            this.chckTienda2.TabIndex = 22;
            this.chckTienda2.Text = "Tienda 2";
            this.chckTienda2.UseVisualStyleBackColor = true;
            this.chckTienda2.CheckedChanged += new System.EventHandler(this.chckTienda2_CheckedChanged);
            // 
            // chckTienda1
            // 
            this.chckTienda1.AutoSize = true;
            this.chckTienda1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckTienda1.Location = new System.Drawing.Point(448, 172);
            this.chckTienda1.Name = "chckTienda1";
            this.chckTienda1.Size = new System.Drawing.Size(77, 21);
            this.chckTienda1.TabIndex = 21;
            this.chckTienda1.Text = "Tienda 1";
            this.chckTienda1.UseVisualStyleBackColor = true;
            this.chckTienda1.CheckedChanged += new System.EventHandler(this.chckTienda1_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(28, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 25);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPelicula.Location = new System.Drawing.Point(28, 41);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(158, 25);
            this.txtTituloPelicula.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 18;
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
            this.lstPeliculas.Location = new System.Drawing.Point(28, 124);
            this.lstPeliculas.MultiSelect = false;
            this.lstPeliculas.Name = "lstPeliculas";
            this.lstPeliculas.Size = new System.Drawing.Size(323, 187);
            this.lstPeliculas.TabIndex = 17;
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
            // FrmEliminarDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.labelPelicula);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chckTienda2);
            this.Controls.Add(this.chckTienda1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPeliculas);
            this.Name = "FrmEliminarDVD";
            this.Text = "Eliminar DVD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEliminarDVD_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPelicula;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chckTienda2;
        private System.Windows.Forms.CheckBox chckTienda1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstPeliculas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}