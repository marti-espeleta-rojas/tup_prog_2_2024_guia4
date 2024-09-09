namespace Ejercicio_1
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
            this.btnIniciarCoperativa = new System.Windows.Forms.Button();
            this.btnCargaClientes = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCargarConsumo = new System.Windows.Forms.Button();
            this.tbCooperativa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Consumo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNroServicio = new System.Windows.Forms.TextBox();
            this.tbCargarConsumo = new System.Windows.Forms.TextBox();
            this.btnVerConsumo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Consumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarCoperativa
            // 
            this.btnIniciarCoperativa.Location = new System.Drawing.Point(415, 15);
            this.btnIniciarCoperativa.Name = "btnIniciarCoperativa";
            this.btnIniciarCoperativa.Size = new System.Drawing.Size(109, 23);
            this.btnIniciarCoperativa.TabIndex = 0;
            this.btnIniciarCoperativa.Text = "Iniciar Cooperativa";
            this.btnIniciarCoperativa.UseVisualStyleBackColor = true;
            this.btnIniciarCoperativa.Click += new System.EventHandler(this.btnIniciarCoperativa_Click);
            // 
            // btnCargaClientes
            // 
            this.btnCargaClientes.Location = new System.Drawing.Point(331, 19);
            this.btnCargaClientes.Name = "btnCargaClientes";
            this.btnCargaClientes.Size = new System.Drawing.Size(103, 23);
            this.btnCargaClientes.TabIndex = 1;
            this.btnCargaClientes.Text = "Carga de Clientes";
            this.btnCargaClientes.UseVisualStyleBackColor = true;
            this.btnCargaClientes.Click += new System.EventHandler(this.btnCargaClientes_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(331, 20);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCargarConsumo
            // 
            this.btnCargarConsumo.Location = new System.Drawing.Point(277, 37);
            this.btnCargarConsumo.Name = "btnCargarConsumo";
            this.btnCargarConsumo.Size = new System.Drawing.Size(99, 23);
            this.btnCargarConsumo.TabIndex = 3;
            this.btnCargarConsumo.Text = "Cargar Consumo";
            this.btnCargarConsumo.UseVisualStyleBackColor = true;
            this.btnCargarConsumo.Click += new System.EventHandler(this.btnCargarConsumo_Click);
            // 
            // tbCooperativa
            // 
            this.tbCooperativa.Location = new System.Drawing.Point(151, 15);
            this.tbCooperativa.Name = "tbCooperativa";
            this.tbCooperativa.Size = new System.Drawing.Size(235, 20);
            this.tbCooperativa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cooperativa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargaClientes);
            this.groupBox1.Location = new System.Drawing.Point(84, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 52);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCliente);
            this.groupBox2.Controls.Add(this.tbNroServicio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Consumo);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Location = new System.Drawing.Point(84, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 281);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultas de Clientes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCargarConsumo);
            this.groupBox3.Controls.Add(this.btnCargarConsumo);
            this.groupBox3.Location = new System.Drawing.Point(30, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carga de Consumos";
            // 
            // Consumo
            // 
            this.Consumo.Controls.Add(this.btnVerConsumo);
            this.Consumo.Location = new System.Drawing.Point(30, 188);
            this.Consumo.Name = "Consumo";
            this.Consumo.Size = new System.Drawing.Size(387, 69);
            this.Consumo.TabIndex = 5;
            this.Consumo.TabStop = false;
            this.Consumo.Text = "Consumo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de Servicio";
            // 
            // tbNroServicio
            // 
            this.tbNroServicio.Location = new System.Drawing.Point(123, 22);
            this.tbNroServicio.Name = "tbNroServicio";
            this.tbNroServicio.Size = new System.Drawing.Size(191, 20);
            this.tbNroServicio.TabIndex = 7;
            // 
            // tbCargarConsumo
            // 
            this.tbCargarConsumo.Location = new System.Drawing.Point(82, 37);
            this.tbCargarConsumo.Name = "tbCargarConsumo";
            this.tbCargarConsumo.Size = new System.Drawing.Size(190, 20);
            this.tbCargarConsumo.TabIndex = 4;
            // 
            // btnVerConsumo
            // 
            this.btnVerConsumo.Location = new System.Drawing.Point(157, 28);
            this.btnVerConsumo.Name = "btnVerConsumo";
            this.btnVerConsumo.Size = new System.Drawing.Size(224, 23);
            this.btnVerConsumo.TabIndex = 0;
            this.btnVerConsumo.Text = "Ver Consumo";
            this.btnVerConsumo.UseVisualStyleBackColor = true;
            this.btnVerConsumo.Click += new System.EventHandler(this.btnVerConsumo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(250, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(138, 49);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(16, 13);
            this.lbCliente.TabIndex = 8;
            this.lbCliente.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCooperativa);
            this.Controls.Add(this.btnIniciarCoperativa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Consumo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCoperativa;
        private System.Windows.Forms.Button btnCargaClientes;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCargarConsumo;
        private System.Windows.Forms.TextBox tbCooperativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Consumo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNroServicio;
        private System.Windows.Forms.TextBox tbCargarConsumo;
        private System.Windows.Forms.Button btnVerConsumo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbCliente;
    }
}

