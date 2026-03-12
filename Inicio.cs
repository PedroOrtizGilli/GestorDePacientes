namespace GestorDePaciente
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            DatabaseHelper.InicializarBaseDatos();
        }

        private void inicio_Load(Object sender, EventArgs e)
        {
            cargarPacientesVencidos();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = true;
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

            cargarPacientesVencidos(); ;
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
