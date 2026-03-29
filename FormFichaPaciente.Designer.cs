namespace GestorDePaciente
{
    partial class FormFichaPaciente
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
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtEdad = new TextBox();
            txtObraSocial = new TextBox();
            txtTelefono = new TextBox();
            txtMail = new TextBox();
            txtDescripcion = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnActualizar = new Button();
            btnRecetas = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(313, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(139, 164);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(313, 23);
            txtDNI.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(139, 218);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(313, 23);
            txtEdad.TabIndex = 2;
            // 
            // txtObraSocial
            // 
            txtObraSocial.Location = new Point(139, 271);
            txtObraSocial.Name = "txtObraSocial";
            txtObraSocial.Size = new Size(313, 23);
            txtObraSocial.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(139, 339);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(313, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(139, 394);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(313, 23);
            txtMail.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(139, 459);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(313, 96);
            txtDescripcion.TabIndex = 6;
            txtDescripcion.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 117);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 167);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 8;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 279);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "Obra Social";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 347);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 402);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 226);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "Edad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 462);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 13;
            label7.Text = "Descripcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(151, 22);
            label8.Name = "label8";
            label8.Size = new Size(269, 37);
            label8.TabIndex = 16;
            label8.Text = "Ficha Paciente";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(211, 622);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(147, 52);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRecetas
            // 
            btnRecetas.Location = new Point(232, 572);
            btnRecetas.Name = "btnRecetas";
            btnRecetas.Size = new Size(108, 32);
            btnRecetas.TabIndex = 18;
            btnRecetas.Text = "Ver recetas";
            btnRecetas.UseVisualStyleBackColor = true;
            btnRecetas.Click += btnRecetas_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(211, 689);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(147, 52);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormFichaPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 763);
            Controls.Add(btnEliminar);
            Controls.Add(btnRecetas);
            Controls.Add(btnActualizar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtObraSocial);
            Controls.Add(txtEdad);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Name = "FormFichaPaciente";
            Text = "FormFichaPaciente";
            Load += FormFichaPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtEdad;
        private TextBox txtObraSocial;
        private TextBox txtTelefono;
        private TextBox txtMail;
        private RichTextBox txtDescripcion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnActualizar;
        private Button btnRecetas;
        private Button btnEliminar;
    }
}