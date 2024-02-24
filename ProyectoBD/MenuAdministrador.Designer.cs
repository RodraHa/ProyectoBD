namespace ProyectoBD
{
    partial class MenuAdministrador
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
            this.btnIngresarPelicula = new System.Windows.Forms.Button();
            this.btnIngresarDVD = new System.Windows.Forms.Button();
            this.btnEliminarDVD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarPelicula
            // 
            this.btnIngresarPelicula.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPelicula.Location = new System.Drawing.Point(97, 165);
            this.btnIngresarPelicula.Name = "btnIngresarPelicula";
            this.btnIngresarPelicula.Size = new System.Drawing.Size(135, 31);
            this.btnIngresarPelicula.TabIndex = 0;
            this.btnIngresarPelicula.Text = "Ingresar Pelicula";
            this.btnIngresarPelicula.UseVisualStyleBackColor = true;
            this.btnIngresarPelicula.Click += new System.EventHandler(this.btnIngresarPelicula_Click);
            // 
            // btnIngresarDVD
            // 
            this.btnIngresarDVD.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDVD.Location = new System.Drawing.Point(306, 165);
            this.btnIngresarDVD.Name = "btnIngresarDVD";
            this.btnIngresarDVD.Size = new System.Drawing.Size(112, 31);
            this.btnIngresarDVD.TabIndex = 1;
            this.btnIngresarDVD.Text = "Ingresar DVD";
            this.btnIngresarDVD.UseVisualStyleBackColor = true;
            this.btnIngresarDVD.Click += new System.EventHandler(this.btnIngresarDVD_Click);
            // 
            // btnEliminarDVD
            // 
            this.btnEliminarDVD.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDVD.Location = new System.Drawing.Point(499, 165);
            this.btnEliminarDVD.Name = "btnEliminarDVD";
            this.btnEliminarDVD.Size = new System.Drawing.Size(122, 31);
            this.btnEliminarDVD.TabIndex = 2;
            this.btnEliminarDVD.Text = "Eliminar DVD";
            this.btnEliminarDVD.UseVisualStyleBackColor = true;
            this.btnEliminarDVD.Click += new System.EventHandler(this.btnEliminarDVD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoBD.Properties.Resources.eliminar;
            this.pictureBox3.Location = new System.Drawing.Point(509, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoBD.Properties.Resources.ingresarDVD;
            this.pictureBox2.Location = new System.Drawing.Point(306, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoBD.Properties.Resources.pelicula;
            this.pictureBox1.Location = new System.Drawing.Point(110, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminarDVD);
            this.Controls.Add(this.btnIngresarDVD);
            this.Controls.Add(this.btnIngresarPelicula);
            this.Name = "MenuAdministrador";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarPelicula;
        private System.Windows.Forms.Button btnIngresarDVD;
        private System.Windows.Forms.Button btnEliminarDVD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}