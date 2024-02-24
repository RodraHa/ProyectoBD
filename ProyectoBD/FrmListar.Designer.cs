namespace ProyectoBD
{
    partial class FrmListar
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
            this.btnConsultarDirector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.lstConsultaDVD = new System.Windows.Forms.ListView();
            this.cmBoxGeneros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnConsultarDirector
            // 
            this.btnConsultarDirector.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDirector.Location = new System.Drawing.Point(314, 326);
            this.btnConsultarDirector.Name = "btnConsultarDirector";
            this.btnConsultarDirector.Size = new System.Drawing.Size(88, 26);
            this.btnConsultarDirector.TabIndex = 0;
            this.btnConsultarDirector.Text = "Consultar";
            this.btnConsultarDirector.UseVisualStyleBackColor = true;
            this.btnConsultarDirector.Click += new System.EventHandler(this.btnConsultarDirector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actor";
            // 
            // txtActor
            // 
            this.txtActor.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActor.Location = new System.Drawing.Point(127, 47);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(161, 25);
            this.txtActor.TabIndex = 2;
            // 
            // lstConsultaDVD
            // 
            this.lstConsultaDVD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstConsultaDVD.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstConsultaDVD.HideSelection = false;
            this.lstConsultaDVD.Location = new System.Drawing.Point(127, 106);
            this.lstConsultaDVD.Name = "lstConsultaDVD";
            this.lstConsultaDVD.Size = new System.Drawing.Size(442, 201);
            this.lstConsultaDVD.TabIndex = 3;
            this.lstConsultaDVD.UseCompatibleStateImageBehavior = false;
            this.lstConsultaDVD.View = System.Windows.Forms.View.Details;
            // 
            // cmBoxGeneros
            // 
            this.cmBoxGeneros.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBoxGeneros.FormattingEnabled = true;
            this.cmBoxGeneros.Location = new System.Drawing.Point(448, 47);
            this.cmBoxGeneros.Name = "cmBoxGeneros";
            this.cmBoxGeneros.Size = new System.Drawing.Size(121, 25);
            this.cmBoxGeneros.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Género";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Título";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha de Lanzamiento";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Idioma";
            this.columnHeader3.Width = 105;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmBoxGeneros);
            this.Controls.Add(this.lstConsultaDVD);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarDirector);
            this.Name = "FrmListar";
            this.Text = "Listar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.ListView lstConsultaDVD;
        private System.Windows.Forms.ComboBox cmBoxGeneros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}