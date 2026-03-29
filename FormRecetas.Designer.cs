namespace GestorDePaciente
{
    partial class FormRecetas
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
            listBoxRecetas = new ListBox();
            lblTotal = new Label();
            btnAgregar = new Button();
            lblNombrePaciente = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // listBoxRecetas
            // 
            listBoxRecetas.FormattingEnabled = true;
            listBoxRecetas.Location = new Point(54, 91);
            listBoxRecetas.Name = "listBoxRecetas";
            listBoxRecetas.Size = new Size(455, 304);
            listBoxRecetas.TabIndex = 0;
            listBoxRecetas.DoubleClick += listBoxRecetas_DoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(224, 412);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(92, 450);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 48);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Receta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(191, 23);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(38, 15);
            lblNombrePaciente.TabIndex = 3;
            lblNombrePaciente.Text = "label1";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(323, 450);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 48);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar receta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 530);
            Controls.Add(btnEliminar);
            Controls.Add(lblNombrePaciente);
            Controls.Add(btnAgregar);
            Controls.Add(lblTotal);
            Controls.Add(listBoxRecetas);
            Name = "FormRecetas";
            Load += FormRecetas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRecetas;
        private Label lblTotal;
        private Button btnAgregar;
        private Label lblNombrePaciente;
        private Button btnEliminar;
    }
}