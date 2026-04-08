namespace GestorDePaciente
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            DatabaseHelper.InicializarBaseDatos();
        }

        private void ConfigurarControlesResponsivos()
        {

            label2.AutoSize = false;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(0, 10);
            label2.Size = new Size(this.ClientSize.Width, 60);
            label2.TextAlign = ContentAlignment.MiddleCenter;


            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.Location = new Point(20, 85);

            buscador.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buscador.Location = new Point(90, 82);
            buscador.Width = this.ClientSize.Width - 110; // Ajustado al ancho


            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            int margen = 15;
            int alturaSuperior = 160;

            dataGridView1.Location = new Point(margen, alturaSuperior);
            dataGridView1.Width = this.ClientSize.Width - (margen * 2);
            dataGridView1.Height = this.ClientSize.Height - alturaSuperior - 100;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;


            crearNuevo.Anchor = AnchorStyles.Bottom;
            int btnX = (this.ClientSize.Width - crearNuevo.Width) / 2; // Centrado
            int btnY = this.ClientSize.Height - 70;
            crearNuevo.Location = new Point(btnX, btnY);
        }

        private void inicio_Load(Object sender, EventArgs e)
        {
            ConfigurarControlesResponsivos();
            cargarPacientesVencidos();
        }


        private void cargarPacientesVencidos()
        {
            try
            {
                var todosLosPacientes = Crud.PacienteDAO.ObtenerTodos();

                var pacientesVencidos = todosLosPacientes.Where(p =>
                {
                    var recetas = Crud.RecetaDAO.ObtenerPorPaciente(p.Id);

                    if (recetas.Count == 0)
                    {
                        return false;
                    }

                    var ultimaReceta = recetas.OrderByDescending(r => r.FechaEmision).First();

                    var mesDiferencia = ((DateTime.Now.Year - ultimaReceta.FechaEmision.Value.Year) * 12) + DateTime.Now.Month - ultimaReceta.FechaEmision.Value.Month;

                    return mesDiferencia > 3;

                }).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pacientesVencidos;

                if (dataGridView1.Columns["Descripcion"] != null)
                {
                    dataGridView1.Columns["Descripcion"].Visible = false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar pacientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscador.Text))
            {
                cargarPacientesVencidos();
            } else
            {
                var resultados = Crud.PacienteDAO.Buscar(buscador.Text);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultados;
            }
        }

        private void crearNuevo_Click(object sender, EventArgs e)
        {
            var formNuevo = new FormNuevoPaciente();
            formNuevo.ShowDialog();

            cargarPacientesVencidos();
            Console.WriteLine("Abro el form de nuevo paciente");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                AbrirFichaPaciente();
            }
        }

        private void AbrirFichaPaciente()
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int pacienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            var formFicha = new FormFichaPaciente(pacienteId);
            formFicha.ShowDialog();

            cargarPacientesVencidos();
        }


    }
}
