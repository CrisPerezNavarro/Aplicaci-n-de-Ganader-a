namespace Registro_Vacuno
{
    partial class Tratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tratamiento));
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.CodigoRes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txDosis = new System.Windows.Forms.Label();
            this.txMedicamento = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.Label();
            this.Medicamento = new System.Windows.Forms.TextBox();
            this.Dosis = new System.Windows.Forms.TextBox();
            this.Diagnostico = new System.Windows.Forms.TextBox();
            this.DTfecha = new System.Windows.Forms.DateTimePicker();
            this.Detalle = new System.Windows.Forms.RichTextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCodigo
            // 
            this.cbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(206, 37);
            this.cbCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(108, 33);
            this.cbCodigo.TabIndex = 0;
            this.cbCodigo.Text = "Seleccione";
            // 
            // CodigoRes
            // 
            this.CodigoRes.AutoSize = true;
            this.CodigoRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CodigoRes.Location = new System.Drawing.Point(34, 40);
            this.CodigoRes.Name = "CodigoRes";
            this.CodigoRes.Size = new System.Drawing.Size(154, 25);
            this.CodigoRes.TabIndex = 1;
            this.CodigoRes.Text = "Codigo de Res";
            this.CodigoRes.Click += new System.EventHandler(this.CodigoRes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detalle";
            // 
            // txDosis
            // 
            this.txDosis.AutoSize = true;
            this.txDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDosis.Location = new System.Drawing.Point(448, 177);
            this.txDosis.Name = "txDosis";
            this.txDosis.Size = new System.Drawing.Size(66, 25);
            this.txDosis.TabIndex = 3;
            this.txDosis.Text = "Dosis";
            // 
            // txMedicamento
            // 
            this.txMedicamento.AutoSize = true;
            this.txMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txMedicamento.Location = new System.Drawing.Point(372, 40);
            this.txMedicamento.Name = "txMedicamento";
            this.txMedicamento.Size = new System.Drawing.Size(141, 25);
            this.txMedicamento.TabIndex = 5;
            this.txMedicamento.Text = "Medicamento";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.AutoSize = true;
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDiagnostico.Location = new System.Drawing.Point(34, 180);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(113, 25);
            this.txtDiagnostico.TabIndex = 6;
            this.txtDiagnostico.Text = "Dignostico";
            // 
            // Medicamento
            // 
            this.Medicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Medicamento.Location = new System.Drawing.Point(524, 40);
            this.Medicamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Medicamento.Name = "Medicamento";
            this.Medicamento.Size = new System.Drawing.Size(204, 30);
            this.Medicamento.TabIndex = 8;
            // 
            // Dosis
            // 
            this.Dosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Dosis.Location = new System.Drawing.Point(524, 177);
            this.Dosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dosis.Name = "Dosis";
            this.Dosis.Size = new System.Drawing.Size(204, 30);
            this.Dosis.TabIndex = 9;
            // 
            // Diagnostico
            // 
            this.Diagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Diagnostico.Location = new System.Drawing.Point(206, 177);
            this.Diagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Size = new System.Drawing.Size(204, 30);
            this.Diagnostico.TabIndex = 11;
            // 
            // DTfecha
            // 
            this.DTfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DTfecha.Location = new System.Drawing.Point(206, 103);
            this.DTfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTfecha.Name = "DTfecha";
            this.DTfecha.Size = new System.Drawing.Size(301, 30);
            this.DTfecha.TabIndex = 13;
            // 
            // Detalle
            // 
            this.Detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Detalle.Location = new System.Drawing.Point(206, 247);
            this.Detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(256, 105);
            this.Detalle.TabIndex = 14;
            this.Detalle.Text = "";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(76, 394);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 32);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(512, 394);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 32);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Caduca";
            // 
            // Tratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(740, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.Detalle);
            this.Controls.Add(this.DTfecha);
            this.Controls.Add(this.Diagnostico);
            this.Controls.Add(this.Dosis);
            this.Controls.Add(this.Medicamento);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txMedicamento);
            this.Controls.Add(this.txDosis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodigoRes);
            this.Controls.Add(this.cbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tratamiento";
            this.Text = "Tratamiento";
            this.Load += new System.EventHandler(this.Tratamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Label CodigoRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txDosis;
        private System.Windows.Forms.Label txMedicamento;
        private System.Windows.Forms.Label txtDiagnostico;
        private System.Windows.Forms.TextBox Medicamento;
        private System.Windows.Forms.TextBox Dosis;
        private System.Windows.Forms.TextBox Diagnostico;
        private System.Windows.Forms.DateTimePicker DTfecha;
        private System.Windows.Forms.RichTextBox Detalle;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
    }
}