namespace GestorDePaciente
{
    partial class FormNuevoPaciente
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
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtDescripcion = new RichTextBox();
            txtMail = new TextBox();
            txtTelefono = new TextBox();
            txtObraSocial = new TextBox();
            txtEdad = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            btnAgregarRecetas = new Button();
            btnCrear = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 38);
            label1.Name = "label1";
            label1.Size = new Size(269, 37);
            label1.TabIndex = 7;
            label1.Text = "Nuevo Paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 457);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 27;
            label7.Text = "Descripcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 221);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 26;
            label6.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 397);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 25;
            label5.Text = "Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 342);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 24;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 274);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 23;
            label3.Text = "Obra Social";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 162);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 22;
            label2.Text = "DNI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 112);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 21;
            label8.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(132, 454);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(313, 96);
            txtDescripcion.TabIndex = 20;
            txtDescripcion.Text = "";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(132, 389);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(313, 23);
            txtMail.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(132, 334);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(313, 23);
            txtTelefono.TabIndex = 18;
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(132, 266);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(313, 23);
            txtObraSocial.TabIndex = 17;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(132, 213);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(313, 23);
            txtEdad.TabIndex = 16;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(132, 159);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(313, 23);
            txtDNI.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(313, 23);
            txtNombre.TabIndex = 14;
            // 
            // btnAgregarRecetas
            // 
            btnAgregarRecetas.Location = new Point(212, 567);
            btnAgregarRecetas.Name = "btnAgregarRecetas";
            btnAgregarRecetas.Size = new Size(123, 39);
            btnAgregarRecetas.TabIndex = 28;
            btnAgregarRecetas.Text = "Agregar recetas";
            btnAgregarRecetas.UseVisualStyleBackColor = true;
            btnAgregarRecetas.Click += btnAgregarRecetas_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(75, 655);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(168, 66);
            btnCrear.TabIndex = 29;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(321, 655);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 66);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNuevoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 763);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(btnAgregarRecetas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtObraSocial);
            Controls.Add(txtEdad);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormNuevoPaciente";
            Text = "FormNuevoPaciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private RichTextBox txtDescripcion;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private TextBox txtObraSocial;
        private TextBox txtEdad;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Button btnAgregarRecetas;
        private Button btnCrear;
        private Button btnCancelar;
    }
}