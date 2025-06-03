namespace GimnasioClientes
{
    partial class frmClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstClientes = new ListBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            dtpFechaInscripcion = new DateTimePicker();
            cmbMembresia = new ComboBox();
            chkActivo = new CheckBox();
            btnAlta = new Button();
            btnMostrar = new Button();
            btnListar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();

            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 12);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(300, 454);
            lstClientes.TabIndex = 0;
            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(330, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(330, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(330, 130);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 23);
            txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(330, 180);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 23);
            txtCorreo.TabIndex = 4;
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Location = new Point(330, 230);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(250, 23);
            dtpFechaInscripcion.TabIndex = 5;

            // cmbMembresia

            // cmbMembresia
            this.cmbMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembresia.FormattingEnabled = true;
            this.cmbMembresia.Location = new System.Drawing.Point(330, 280);
            this.cmbMembresia.Name = "cmbMembresia";
            this.cmbMembresia.Size = new System.Drawing.Size(250, 23);
            this.cmbMembresia.TabIndex = 6;
            // (NO debe haber Items.AddRange aquí)
            // (Elimina la línea que agrega los items aquí)
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(330, 320);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(330, 350);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(120, 30);
            btnAlta.TabIndex = 8;
            btnAlta.Text = "1. Alta Cliente";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(460, 350);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(120, 30);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "2. Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(330, 390);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(120, 30);
            btnListar.TabIndex = 10;
            btnListar.Text = "3. Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(460, 390);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 30);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "4. Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(330, 430);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 30);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "5. Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(460, 430);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 30);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "6. Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(330, 470);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 30);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "7. Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(330, 520);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 23);
            txtBuscar.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 17;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 112);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 18;
            label3.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 162);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 19;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 212);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 20;
            label5.Text = "Fecha Inscripción:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 262);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 21;
            label6.Text = "Membresía:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 502);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 22;
            label7.Text = "Buscar:";
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 560);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnListar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAlta);
            Controls.Add(chkActivo);
            Controls.Add(cmbMembresia);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lstClientes);
            Name = "frmClientes";
            Text = "Gestión de Clientes - Gimnasio";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.ComboBox cmbMembresia;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}