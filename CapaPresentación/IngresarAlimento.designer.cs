namespace Registro_Vacuno
{
    partial class IngresarAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarAlimento));
            this.Producto = new System.Windows.Forms.TextBox();
            this.NombreProducto = new System.Windows.Forms.Label();
            this.CantidadSacos = new System.Windows.Forms.Label();
            this.Sacos = new System.Windows.Forms.TextBox();
            this.btnIngresarAlimento = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Producto
            // 
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.Location = new System.Drawing.Point(265, 54);
            this.Producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(148, 30);
            this.Producto.TabIndex = 1;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSize = true;
            this.NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto.Location = new System.Drawing.Point(25, 54);
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Size = new System.Drawing.Size(209, 25);
            this.NombreProducto.TabIndex = 2;
            this.NombreProducto.Text = "Nombre de Producto";
            // 
            // CantidadSacos
            // 
            this.CantidadSacos.AutoSize = true;
            this.CantidadSacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadSacos.Location = new System.Drawing.Point(65, 114);
            this.CantidadSacos.Name = "CantidadSacos";
            this.CantidadSacos.Size = new System.Drawing.Size(166, 25);
            this.CantidadSacos.TabIndex = 3;
            this.CantidadSacos.Text = "Cantidad Sacos";
            // 
            // Sacos
            // 
            this.Sacos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sacos.Location = new System.Drawing.Point(265, 114);
            this.Sacos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sacos.Name = "Sacos";
            this.Sacos.Size = new System.Drawing.Size(148, 30);
            this.Sacos.TabIndex = 4;
            // 
            // btnIngresarAlimento
            // 
            this.btnIngresarAlimento.AutoSize = true;
            this.btnIngresarAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAlimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarAlimento.Location = new System.Drawing.Point(86, 222);
            this.btnIngresarAlimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarAlimento.Name = "btnIngresarAlimento";
            this.btnIngresarAlimento.Size = new System.Drawing.Size(130, 35);
            this.btnIngresarAlimento.TabIndex = 13;
            this.btnIngresarAlimento.Text = "Ingresar ";
            this.btnIngresarAlimento.UseVisualStyleBackColor = false;
            this.btnIngresarAlimento.Click += new System.EventHandler(this.btnIngresarAlimento_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(265, 222);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 32);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // IngresarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(487, 360);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresarAlimento);
            this.Controls.Add(this.Sacos);
            this.Controls.Add(this.CantidadSacos);
            this.Controls.Add(this.NombreProducto);
            this.Controls.Add(this.Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IngresarAlimento";
            this.Text = "IngresarAlimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Producto;
        private System.Windows.Forms.Label NombreProducto;
        private System.Windows.Forms.Label CantidadSacos;
        private System.Windows.Forms.TextBox Sacos;
        private System.Windows.Forms.Button btnIngresarAlimento;
        private System.Windows.Forms.Button btnSalir;
    }
}