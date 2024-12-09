namespace Registro_Vacuno
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMiminizar = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarInforma = new System.Windows.Forms.Button();
            this.btnConsultarProducto = new System.Windows.Forms.Button();
            this.btnGastoAlimento = new System.Windows.Forms.Button();
            this.btnIngresarAlimento = new System.Windows.Forms.Button();
            this.btnVacunaUsada = new System.Windows.Forms.Button();
            this.btnIngresarVacuna = new System.Windows.Forms.Button();
            this.btnConTratamiento = new System.Windows.Forms.Button();
            this.btnregistroTratamiento = new System.Windows.Forms.Button();
            this.btnConsultarRes = new System.Windows.Forms.Button();
            this.btnEliminarRes = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresarRes = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiminizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.Aquamarine;
            this.barraTitulo.Controls.Add(this.btnMiminizar);
            this.barraTitulo.Controls.Add(this.btnVolver);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1095, 28);
            this.barraTitulo.TabIndex = 0;
            // 
            // btnMiminizar
            // 
            this.btnMiminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiminizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnMiminizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMiminizar.Image")));
            this.btnMiminizar.Location = new System.Drawing.Point(979, 0);
            this.btnMiminizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMiminizar.Name = "btnMiminizar";
            this.btnMiminizar.Size = new System.Drawing.Size(31, 28);
            this.btnMiminizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMiminizar.TabIndex = 3;
            this.btnMiminizar.TabStop = false;
            this.btnMiminizar.Click += new System.EventHandler(this.btnMiminizar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.SystemColors.Window;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(1015, 0);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(31, 28);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 2;
            this.btnVolver.TabStop = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1015, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(31, 28);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1052, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.btnGenerarInforma);
            this.panel1.Controls.Add(this.btnConsultarProducto);
            this.panel1.Controls.Add(this.btnGastoAlimento);
            this.panel1.Controls.Add(this.btnIngresarAlimento);
            this.panel1.Controls.Add(this.btnVacunaUsada);
            this.panel1.Controls.Add(this.btnIngresarVacuna);
            this.panel1.Controls.Add(this.btnConTratamiento);
            this.panel1.Controls.Add(this.btnregistroTratamiento);
            this.panel1.Controls.Add(this.btnConsultarRes);
            this.panel1.Controls.Add(this.btnEliminarRes);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnIngresarRes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 581);
            this.panel1.TabIndex = 1;
            // 
            // btnGenerarInforma
            // 
            this.btnGenerarInforma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGenerarInforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerarInforma.Location = new System.Drawing.Point(1, 467);
            this.btnGenerarInforma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarInforma.Name = "btnGenerarInforma";
            this.btnGenerarInforma.Size = new System.Drawing.Size(265, 42);
            this.btnGenerarInforma.TabIndex = 12;
            this.btnGenerarInforma.Text = "Generar Informe";
            this.btnGenerarInforma.UseVisualStyleBackColor = false;
            this.btnGenerarInforma.Click += new System.EventHandler(this.btnGenerarInforma_Click);
            // 
            // btnConsultarProducto
            // 
            this.btnConsultarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConsultarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultarProducto.Location = new System.Drawing.Point(1, 421);
            this.btnConsultarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarProducto.Name = "btnConsultarProducto";
            this.btnConsultarProducto.Size = new System.Drawing.Size(265, 42);
            this.btnConsultarProducto.TabIndex = 10;
            this.btnConsultarProducto.Text = "Inventario";
            this.btnConsultarProducto.UseVisualStyleBackColor = false;
            this.btnConsultarProducto.Click += new System.EventHandler(this.btnConsultarProducto_Click);
            // 
            // btnGastoAlimento
            // 
            this.btnGastoAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGastoAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGastoAlimento.Location = new System.Drawing.Point(1, 378);
            this.btnGastoAlimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGastoAlimento.Name = "btnGastoAlimento";
            this.btnGastoAlimento.Size = new System.Drawing.Size(265, 42);
            this.btnGastoAlimento.TabIndex = 9;
            this.btnGastoAlimento.Text = "Gasto de Alimento";
            this.btnGastoAlimento.UseVisualStyleBackColor = false;
            this.btnGastoAlimento.Click += new System.EventHandler(this.btnGastoAlimento_Click);
            // 
            // btnIngresarAlimento
            // 
            this.btnIngresarAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresarAlimento.Location = new System.Drawing.Point(3, 336);
            this.btnIngresarAlimento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarAlimento.Name = "btnIngresarAlimento";
            this.btnIngresarAlimento.Size = new System.Drawing.Size(265, 42);
            this.btnIngresarAlimento.TabIndex = 8;
            this.btnIngresarAlimento.Text = "Agregar Alimento";
            this.btnIngresarAlimento.UseVisualStyleBackColor = false;
            this.btnIngresarAlimento.Click += new System.EventHandler(this.btnIngresarAlimento_Click);
            // 
            // btnVacunaUsada
            // 
            this.btnVacunaUsada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVacunaUsada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVacunaUsada.Location = new System.Drawing.Point(1, 294);
            this.btnVacunaUsada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVacunaUsada.Name = "btnVacunaUsada";
            this.btnVacunaUsada.Size = new System.Drawing.Size(265, 42);
            this.btnVacunaUsada.TabIndex = 7;
            this.btnVacunaUsada.Text = "Gasto de Medicamento";
            this.btnVacunaUsada.UseVisualStyleBackColor = false;
            this.btnVacunaUsada.Click += new System.EventHandler(this.btnVacunaUsada_Click);
            // 
            // btnIngresarVacuna
            // 
            this.btnIngresarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresarVacuna.Location = new System.Drawing.Point(0, 252);
            this.btnIngresarVacuna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarVacuna.Name = "btnIngresarVacuna";
            this.btnIngresarVacuna.Size = new System.Drawing.Size(265, 42);
            this.btnIngresarVacuna.TabIndex = 6;
            this.btnIngresarVacuna.Text = "Agregar Medicamento";
            this.btnIngresarVacuna.UseVisualStyleBackColor = false;
            this.btnIngresarVacuna.Click += new System.EventHandler(this.btnIngresarVacuna_Click);
            // 
            // btnConTratamiento
            // 
            this.btnConTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConTratamiento.Location = new System.Drawing.Point(3, 210);
            this.btnConTratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConTratamiento.Name = "btnConTratamiento";
            this.btnConTratamiento.Size = new System.Drawing.Size(265, 42);
            this.btnConTratamiento.TabIndex = 5;
            this.btnConTratamiento.Text = "Consultar Tratamiento";
            this.btnConTratamiento.UseVisualStyleBackColor = false;
            this.btnConTratamiento.Click += new System.EventHandler(this.btnConTratamiento_Click);
            // 
            // btnregistroTratamiento
            // 
            this.btnregistroTratamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnregistroTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnregistroTratamiento.Location = new System.Drawing.Point(3, 169);
            this.btnregistroTratamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregistroTratamiento.Name = "btnregistroTratamiento";
            this.btnregistroTratamiento.Size = new System.Drawing.Size(265, 42);
            this.btnregistroTratamiento.TabIndex = 4;
            this.btnregistroTratamiento.Text = "Registrar Tratamiento";
            this.btnregistroTratamiento.UseVisualStyleBackColor = false;
            this.btnregistroTratamiento.Click += new System.EventHandler(this.btnregistroTratamiento_Click);
            // 
            // btnConsultarRes
            // 
            this.btnConsultarRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConsultarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultarRes.Location = new System.Drawing.Point(4, 127);
            this.btnConsultarRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarRes.Name = "btnConsultarRes";
            this.btnConsultarRes.Size = new System.Drawing.Size(265, 42);
            this.btnConsultarRes.TabIndex = 3;
            this.btnConsultarRes.Text = "Consultar Res";
            this.btnConsultarRes.UseVisualStyleBackColor = false;
            this.btnConsultarRes.Click += new System.EventHandler(this.btnConsultarRes_Click);
            // 
            // btnEliminarRes
            // 
            this.btnEliminarRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminarRes.Location = new System.Drawing.Point(4, 86);
            this.btnEliminarRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarRes.Name = "btnEliminarRes";
            this.btnEliminarRes.Size = new System.Drawing.Size(265, 42);
            this.btnEliminarRes.TabIndex = 2;
            this.btnEliminarRes.Text = "Eliminar Res";
            this.btnEliminarRes.UseVisualStyleBackColor = false;
            this.btnEliminarRes.Click += new System.EventHandler(this.btnEliminarRes_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnModificar.Location = new System.Drawing.Point(4, 44);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(265, 42);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modoficar Res";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresarRes
            // 
            this.btnIngresarRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIngresarRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIngresarRes.Location = new System.Drawing.Point(4, 2);
            this.btnIngresarRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarRes.Name = "btnIngresarRes";
            this.btnIngresarRes.Size = new System.Drawing.Size(265, 42);
            this.btnIngresarRes.TabIndex = 0;
            this.btnIngresarRes.Text = "Registro de Res";
            this.btnIngresarRes.UseVisualStyleBackColor = false;
            this.btnIngresarRes.Click += new System.EventHandler(this.btnIngresarRes_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(272, 28);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(823, 581);
            this.panelContenedor.TabIndex = 2;
            
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 609);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMiminizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnMiminizar;
        private System.Windows.Forms.Button btnIngresarRes;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarRes;
        private System.Windows.Forms.Button btnConsultarRes;
        private System.Windows.Forms.Button btnregistroTratamiento;
        private System.Windows.Forms.Button btnConTratamiento;
        private System.Windows.Forms.Button btnIngresarVacuna;
        private System.Windows.Forms.Button btnVacunaUsada;
        private System.Windows.Forms.Button btnIngresarAlimento;
        private System.Windows.Forms.Button btnGastoAlimento;
        private System.Windows.Forms.Button btnConsultarProducto;
        private System.Windows.Forms.Button btnGenerarInforma;
    }
}