namespace Registro_Vacuno
{
    partial class IngresarVacunas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarVacunas));
            this.btnIngresarVacuna = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.txMedicamento = new System.Windows.Forms.Label();
            this.Medicamento = new System.Windows.Forms.TextBox();
            this.txContenido = new System.Windows.Forms.Label();
            this.Contenido = new System.Windows.Forms.TextBox();
            this.CMBTipo = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.txTemperatura = new System.Windows.Forms.Label();
            this.FVencimiento = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Temperatura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIngresarVacuna
            // 
            this.btnIngresarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresarVacuna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarVacuna.Location = new System.Drawing.Point(131, 325);
            this.btnIngresarVacuna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarVacuna.Name = "btnIngresarVacuna";
            this.btnIngresarVacuna.Size = new System.Drawing.Size(130, 32);
            this.btnIngresarVacuna.TabIndex = 13;
            this.btnIngresarVacuna.Text = "Agregar";
            this.btnIngresarVacuna.UseVisualStyleBackColor = false;
            this.btnIngresarVacuna.Click += new System.EventHandler(this.btnIngresarVacuna_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Salir.Location = new System.Drawing.Point(622, 325);
            this.Salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(130, 32);
            this.Salir.TabIndex = 14;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // txMedicamento
            // 
            this.txMedicamento.AutoSize = true;
            this.txMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMedicamento.Location = new System.Drawing.Point(41, 70);
            this.txMedicamento.Name = "txMedicamento";
            this.txMedicamento.Size = new System.Drawing.Size(141, 25);
            this.txMedicamento.TabIndex = 15;
            this.txMedicamento.Text = "Medicamento";
            // 
            // Medicamento
            // 
            this.Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicamento.Location = new System.Drawing.Point(245, 67);
            this.Medicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.Size = new System.Drawing.Size(184, 30);
            this.Medicamento.TabIndex = 16;
            // 
            // txContenido
            // 
            this.txContenido.AutoSize = true;
            this.txContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txContenido.Location = new System.Drawing.Point(453, 68);
            this.txContenido.Name = "txContenido";
            this.txContenido.Size = new System.Drawing.Size(155, 25);
            this.txContenido.TabIndex = 17;
            this.txContenido.Text = "Contenido (ml)";
            // 
            // Contenido
            // 
            this.Contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Contenido.Location = new System.Drawing.Point(622, 65);
            this.Contenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(184, 30);
            this.Contenido.TabIndex = 18;
            // 
            // CMBTipo
            // 
            this.CMBTipo.AutoSize = true;
            this.CMBTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBTipo.Location = new System.Drawing.Point(523, 136);
            this.CMBTipo.Name = "CMBTipo";
            this.CMBTipo.Size = new System.Drawing.Size(61, 25);
            this.CMBTipo.TabIndex = 19;
            this.CMBTipo.Text = "Tipo ";
            // 
            // Tipo
            // 
            this.Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Items.AddRange(new object[] {
            "Inyectable inframuscular",
            "Inyectable subcutaneo",
            "Crema",
            "Pastilla"});
            this.Tipo.Location = new System.Drawing.Point(622, 133);
            this.Tipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(184, 33);
            this.Tipo.TabIndex = 20;
            // 
            // txTemperatura
            // 
            this.txTemperatura.AutoSize = true;
            this.txTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTemperatura.Location = new System.Drawing.Point(16, 136);
            this.txTemperatura.Name = "txTemperatura";
            this.txTemperatura.Size = new System.Drawing.Size(254, 25);
            this.txTemperatura.TabIndex = 21;
            this.txTemperatura.Text = "Temperatura Almacenaje";
            // 
            // FVencimiento
            // 
            this.FVencimiento.AutoSize = true;
            this.FVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FVencimiento.Location = new System.Drawing.Point(80, 209);
            this.FVencimiento.Name = "FVencimiento";
            this.FVencimiento.Size = new System.Drawing.Size(197, 25);
            this.FVencimiento.TabIndex = 22;
            this.FVencimiento.Text = "Fecha Vencimiento";
            // 
            // Fecha
            // 
            this.Fecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(320, 204);
            this.Fecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(286, 30);
            this.Fecha.TabIndex = 23;
            // 
            // Temperatura
            // 
            this.Temperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Temperatura.Location = new System.Drawing.Point(318, 133);
            this.Temperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(112, 30);
            this.Temperatura.TabIndex = 24;
            // 
            // IngresarVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 486);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.FVencimiento);
            this.Controls.Add(this.txTemperatura);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.CMBTipo);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.txContenido);
            this.Controls.Add(this.Medicamento);
            this.Controls.Add(this.txMedicamento);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnIngresarVacuna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IngresarVacunas";
            this.Text = "IngresarVacunas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarVacuna;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label txMedicamento;
        private System.Windows.Forms.TextBox Medicamento;
        private System.Windows.Forms.Label txContenido;
        private System.Windows.Forms.TextBox Contenido;
        private System.Windows.Forms.Label CMBTipo;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.Label txTemperatura;
        private System.Windows.Forms.Label FVencimiento;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.TextBox Temperatura;
    }
}