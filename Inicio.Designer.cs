
namespace GestorDePaciente
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buscador = new TextBox();
            label1 = new Label();
            crearNuevo = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1221, 410);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buscador
            // 
            buscador.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscador.Location = new Point(62, 90);
            buscador.Name = "buscador";
            buscador.Size = new Size(481, 22);
            buscador.TabIndex = 4;
            buscador.TextChanged += buscador_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 93);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar";
            // 
            // crearNuevo
            // 
            crearNuevo.Anchor = AnchorStyles.Bottom;
            crearNuevo.BackColor = Color.YellowGreen;
            crearNuevo.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearNuevo.Location = new Point(513, 600);
            crearNuevo.Name = "crearNuevo";
            crearNuevo.Size = new Size(198, 58);
            crearNuevo.TabIndex = 6;
            crearNuevo.Text = "Nuevo Paciente";
            crearNuevo.UseVisualStyleBackColor = false;
            crearNuevo.Click += crearNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 20);
            label2.Name = "label2";
            label2.Size = new Size(830, 56);
            label2.TabIndex = 7;
            label2.Text = "Sistema de Gestión de pacientes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1260, 686);
            Controls.Add(label2);
            Controls.Add(crearNuevo);
            Controls.Add(label1);
            Controls.Add(buscador);
            Controls.Add(dataGridView1);
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox buscador;
        private Label label1;
        private Button crearNuevo;
        private Label label2;
    }
}
