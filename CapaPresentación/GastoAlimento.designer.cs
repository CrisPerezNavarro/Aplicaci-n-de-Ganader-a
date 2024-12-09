namespace Registro_Vacuno
{
    partial class GastoAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastoAlimento));
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.NombreProducto = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.ComboBox();
            this.txCantidadUsada = new System.Windows.Forms.Label();
            this.btnAlimentoUsado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cantidad
            // 
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cantidad.Location = new System.Drawing.Point(298, 117);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(148, 30);
            this.Cantidad.TabIndex = 1;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSize = true;
            this.NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.Location = new System.Drawing.Point(57, 59);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(209, 25);
            this.NombreProducto.TabIndex = 2;
            this.NombreProducto.Text = "Nombre de Producto";
            // 
            // Producto
            // 
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Producto.FormattingEnabled = true;
            this.Producto.Location = new System.Drawing.Point(298, 59);
            this.Producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(148, 33);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "Selección";
            // 
            // txCantidadUsada
            // 
            this.txCantidadUsada.AutoSize = true;
            this.txCantidadUsada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCantidadUsada.Location = new System.Drawing.Point(96, 119);
            this.txCantidadUsada.Name = "txCantidadUsada";
            this.txCantidadUsada.Size = new System.Drawing.Size(167, 25);
            this.txCantidadUsada.TabIndex = 4;
            this.txCantidadUsada.Text = "Cantidad Usada";
            // 
            // btnAlimentoUsado
            // 
            this.btnAlimentoUsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAlimentoUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlimentoUsado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlimentoUsado.Location = new System.Drawing.Point(75, 242);
            this.btnAlimentoUsado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlimentoUsado.Name = "btnAlimentoUsado";
            this.btnAlimentoUsado.Size = new System.Drawing.Size(130, 32);
            this.btnAlimentoUsado.TabIndex = 13;
            this.btnAlimentoUsado.Text = "Ingresar ";
            this.btnAlimentoUsado.UseVisualStyleBackColor = false;
            this.btnAlimentoUsado.Click += new System.EventHandler(this.btnAlimentoUsado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(298, 242);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GastoAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(516, 360);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAlimentoUsado);
            this.Controls.Add(this.txCantidadUsada);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.Cantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GastoAlimento";
            this.Text = "GastoAlimento";
            this.Load += new System.EventHandler(this.GastoAlimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label NombreProducto;
        private System.Windows.Forms.ComboBox Producto;
        private System.Windows.Forms.Label txCantidadUsada;
        private System.Windows.Forms.Button btnAlimentoUsado;
        private System.Windows.Forms.Button btnSalir;
    }
}