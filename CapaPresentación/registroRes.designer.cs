namespace Registro_Vacuno
{
    partial class RegistroVacuno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVacuno));
            this.CodigoRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Raza = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoRes
            // 
            this.CodigoRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodigoRes.Location = new System.Drawing.Point(128, 26);
            this.CodigoRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodigoRes.Name = "CodigoRes";
            this.CodigoRes.Size = new System.Drawing.Size(148, 30);
            this.CodigoRes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // Raza
            // 
            this.Raza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Raza.Location = new System.Drawing.Point(486, 91);
            this.Raza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(148, 30);
            this.Raza.TabIndex = 2;
            // 
            // Peso
            // 
            this.Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Peso.Location = new System.Drawing.Point(486, 29);
            this.Peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(148, 30);
            this.Peso.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fecha.Location = new System.Drawing.Point(348, 192);
            this.Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.Fecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(287, 30);
            this.Fecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Peso kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sexo";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(37, 360);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(130, 32);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "Ingresar Res";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Sexo
            // 
            this.Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.Sexo.Location = new System.Drawing.Point(128, 87);
            this.Sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(148, 33);
            this.Sexo.TabIndex = 13;
            // 
            // Estado
            // 
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Estado.FormattingEnabled = true;
            this.Estado.Items.AddRange(new object[] {
            "activa",
            "muerta",
            "vendida"});
            this.Estado.Location = new System.Drawing.Point(128, 146);
            this.Estado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(148, 33);
            this.Estado.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(504, 360);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 32);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // RegistroVacuno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(679, 454);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroVacuno";
            this.Text = "Registro Vacuno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Raza;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Button btnSalir;
    }
}

