
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            buscador = new TextBox();
            label1 = new Label();
            crearNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.CornflowerBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, -1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1404, 53);
            textBox1.TabIndex = 2;
            textBox1.Text = "Sistema de gestión de  pacientes";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1295, 410);
            dataGridView1.TabIndex = 3;
            // 
            // buscador
            // 
            buscador.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscador.Location = new Point(62, 90);
            buscador.Name = "buscador";
            buscador.Size = new Size(481, 22);
            buscador.TabIndex = 4;
            buscador.TextChanged += textBox2_TextChanged;
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
            crearNuevo.BackColor = Color.YellowGreen;
            crearNuevo.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearNuevo.Location = new Point(554, 598);
            crearNuevo.Name = "crearNuevo";
            crearNuevo.Size = new Size(198, 58);
            crearNuevo.TabIndex = 6;
            crearNuevo.Text = "Nuevo Paciente";
            crearNuevo.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1319, 689);
            Controls.Add(crearNuevo);
            Controls.Add(label1);
            Controls.Add(buscador);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox buscador;
        private Label label1;
        private Button crearNuevo;
    }
}
