namespace calcular_de_notas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_Alumnos = new System.Windows.Forms.Label();
            this.Id_Alumnos = new System.Windows.Forms.Label();
            this.Nota_primer_corte = new System.Windows.Forms.Label();
            this.Nota_segundo_corte = new System.Windows.Forms.Label();
            this.Nota_tercer_corte = new System.Windows.Forms.Label();
            this.Nota_Final = new System.Windows.Forms.Label();
            this.txb_ne = new System.Windows.Forms.TextBox();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_n1 = new System.Windows.Forms.TextBox();
            this.txb_n2 = new System.Windows.Forms.TextBox();
            this.txb_n3 = new System.Windows.Forms.TextBox();
            this.txb_NF = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(187, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular nota definitiva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre_Alumnos
            // 
            this.Nombre_Alumnos.AutoSize = true;
            this.Nombre_Alumnos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Alumnos.Location = new System.Drawing.Point(84, 123);
            this.Nombre_Alumnos.Name = "Nombre_Alumnos";
            this.Nombre_Alumnos.Size = new System.Drawing.Size(157, 18);
            this.Nombre_Alumnos.TabIndex = 1;
            this.Nombre_Alumnos.Text = "Nombre de alumno";
            this.Nombre_Alumnos.Click += new System.EventHandler(this.Nombre_alumno_Click);
            // 
            // Id_Alumnos
            // 
            this.Id_Alumnos.AutoSize = true;
            this.Id_Alumnos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Alumnos.Location = new System.Drawing.Point(367, 123);
            this.Id_Alumnos.Name = "Id_Alumnos";
            this.Id_Alumnos.Size = new System.Drawing.Size(150, 18);
            this.Id_Alumnos.TabIndex = 2;
            this.Id_Alumnos.Text = "Codigo de alumno";
            // 
            // Nota_primer_corte
            // 
            this.Nota_primer_corte.AutoSize = true;
            this.Nota_primer_corte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota_primer_corte.Location = new System.Drawing.Point(84, 217);
            this.Nota_primer_corte.Name = "Nota_primer_corte";
            this.Nota_primer_corte.Size = new System.Drawing.Size(56, 18);
            this.Nota_primer_corte.TabIndex = 3;
            this.Nota_primer_corte.Text = "Nota1";
            // 
            // Nota_segundo_corte
            // 
            this.Nota_segundo_corte.AutoSize = true;
            this.Nota_segundo_corte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota_segundo_corte.Location = new System.Drawing.Point(288, 214);
            this.Nota_segundo_corte.Name = "Nota_segundo_corte";
            this.Nota_segundo_corte.Size = new System.Drawing.Size(56, 18);
            this.Nota_segundo_corte.TabIndex = 4;
            this.Nota_segundo_corte.Text = "Nota2";
            // 
            // Nota_tercer_corte
            // 
            this.Nota_tercer_corte.AutoSize = true;
            this.Nota_tercer_corte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota_tercer_corte.Location = new System.Drawing.Point(468, 214);
            this.Nota_tercer_corte.Name = "Nota_tercer_corte";
            this.Nota_tercer_corte.Size = new System.Drawing.Size(56, 18);
            this.Nota_tercer_corte.TabIndex = 5;
            this.Nota_tercer_corte.Text = "Nota3";
            // 
            // Nota_Final
            // 
            this.Nota_Final.AutoSize = true;
            this.Nota_Final.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nota_Final.Location = new System.Drawing.Point(256, 318);
            this.Nota_Final.Name = "Nota_Final";
            this.Nota_Final.Size = new System.Drawing.Size(88, 18);
            this.Nota_Final.TabIndex = 6;
            this.Nota_Final.Text = "Nota Final";
            // 
            // txb_ne
            // 
            this.txb_ne.Location = new System.Drawing.Point(87, 157);
            this.txb_ne.Name = "txb_ne";
            this.txb_ne.Size = new System.Drawing.Size(154, 20);
            this.txb_ne.TabIndex = 7;
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(370, 157);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(154, 20);
            this.txb_id.TabIndex = 8;
            // 
            // txb_n1
            // 
            this.txb_n1.Location = new System.Drawing.Point(41, 242);
            this.txb_n1.Name = "txb_n1";
            this.txb_n1.Size = new System.Drawing.Size(154, 20);
            this.txb_n1.TabIndex = 9;
            // 
            // txb_n2
            // 
            this.txb_n2.Location = new System.Drawing.Point(230, 242);
            this.txb_n2.Name = "txb_n2";
            this.txb_n2.Size = new System.Drawing.Size(154, 20);
            this.txb_n2.TabIndex = 10;
            // 
            // txb_n3
            // 
            this.txb_n3.Location = new System.Drawing.Point(416, 242);
            this.txb_n3.Name = "txb_n3";
            this.txb_n3.Size = new System.Drawing.Size(154, 20);
            this.txb_n3.TabIndex = 11;
            // 
            // txb_NF
            // 
            this.txb_NF.Location = new System.Drawing.Point(230, 339);
            this.txb_NF.Name = "txb_NF";
            this.txb_NF.Size = new System.Drawing.Size(154, 20);
            this.txb_NF.TabIndex = 12;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(446, 381);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(133, 43);
            this.btCalcular.TabIndex = 13;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txb_NF);
            this.Controls.Add(this.txb_n3);
            this.Controls.Add(this.txb_n2);
            this.Controls.Add(this.txb_n1);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.txb_ne);
            this.Controls.Add(this.Nota_Final);
            this.Controls.Add(this.Nota_tercer_corte);
            this.Controls.Add(this.Nota_segundo_corte);
            this.Controls.Add(this.Nota_primer_corte);
            this.Controls.Add(this.Id_Alumnos);
            this.Controls.Add(this.Nombre_Alumnos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre_Alumnos;
        private System.Windows.Forms.Label Id_Alumnos;
        private System.Windows.Forms.Label Nota_primer_corte;
        private System.Windows.Forms.Label Nota_segundo_corte;
        private System.Windows.Forms.Label Nota_tercer_corte;
        private System.Windows.Forms.Label Nota_Final;
        private System.Windows.Forms.TextBox txb_ne;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.TextBox txb_n1;
        private System.Windows.Forms.TextBox txb_n2;
        private System.Windows.Forms.TextBox txb_n3;
        private System.Windows.Forms.TextBox txb_NF;
        private System.Windows.Forms.Button btCalcular;
    }
}

