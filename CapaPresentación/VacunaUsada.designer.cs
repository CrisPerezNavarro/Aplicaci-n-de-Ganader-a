namespace Registro_Vacuno
{
    partial class VacunaUsada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacunaUsada));
            this.btnIngresarGasto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.NombreVacuna = new System.Windows.Forms.Label();
            this.FechaVencimiento = new System.Windows.Forms.Label();
            this.txCantidadUsada = new System.Windows.Forms.Label();
            this.CantidadUsada = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ComboBox();
            this.FechaV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnIngresarGasto
            // 
            this.btnIngresarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarGasto.Location = new System.Drawing.Point(87, 259);
            this.btnIngresarGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarGasto.Name = "btnIngresarGasto";
            this.btnIngresarGasto.Size = new System.Drawing.Size(130, 32);
            this.btnIngresarGasto.TabIndex = 13;
            this.btnIngresarGasto.Text = "Ingresar Gasto";
            this.btnIngresarGasto.UseVisualStyleBackColor = false;
            this.btnIngresarGasto.Click += new System.EventHandler(this.btnIngresarGasto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(417, 259);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // NombreVacuna
            // 
            this.NombreVacuna.AutoSize = true;
            this.NombreVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.NombreVacuna.Location = new System.Drawing.Point(83, 55);
            this.NombreVacuna.Name = "NombreVacuna";
            this.NombreVacuna.Size = new System.Drawing.Size(197, 25);
            this.NombreVacuna.TabIndex = 15;
            this.NombreVacuna.Text = "Nombre de Vacuna";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.AutoSize = true;
            this.FechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FechaVencimiento.Location = new System.Drawing.Point(105, 119);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(227, 25);
            this.FechaVencimiento.TabIndex = 17;
            this.FechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // txCantidadUsada
            // 
            this.txCantidadUsada.AutoSize = true;
            this.txCantidadUsada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txCantidadUsada.Location = new System.Drawing.Point(217, 165);
            this.txCantidadUsada.Name = "txCantidadUsada";
            this.txCantidadUsada.Size = new System.Drawing.Size(167, 25);
            this.txCantidadUsada.TabIndex = 19;
            this.txCantidadUsada.Text = "Cantidad Usada";
            // 
            // CantidadUsada
            // 
            this.CantidadUsada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CantidadUsada.Location = new System.Drawing.Point(452, 165);
            this.CantidadUsada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CantidadUsada.Name = "CantidadUsada";
            this.CantidadUsada.Size = new System.Drawing.Size(148, 30);
            this.CantidadUsada.TabIndex = 20;
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(321, 55);
            this.Lista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(144, 33);
            this.Lista.TabIndex = 32;
            // 
            // FechaV
            // 
            this.FechaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaV.FormattingEnabled = true;
            this.FechaV.Location = new System.Drawing.Point(379, 115);
            this.FechaV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaV.Name = "FechaV";
            this.FechaV.Size = new System.Drawing.Size(170, 33);
            this.FechaV.TabIndex = 33;
            // 
            // VacunaUsada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.FechaV);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.CantidadUsada);
            this.Controls.Add(this.txCantidadUsada);
            this.Controls.Add(this.FechaVencimiento);
            this.Controls.Add(this.NombreVacuna);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresarGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VacunaUsada";
            this.Text = "VacunaUsada";
            this.Load += new System.EventHandler(this.VacunaUsada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarGasto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label NombreVacuna;
        private System.Windows.Forms.Label FechaVencimiento;
        private System.Windows.Forms.Label txCantidadUsada;
        private System.Windows.Forms.TextBox CantidadUsada;
        private System.Windows.Forms.ComboBox Lista;
        private System.Windows.Forms.ComboBox FechaV;
    }
}