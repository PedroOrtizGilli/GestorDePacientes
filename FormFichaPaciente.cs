using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestorDePaciente
{
    public partial class FormFichaPaciente : Form
    {
        private int pacienteId;
        private Crud.Paciente pacienteActual;
        public FormFichaPaciente(int Id)
        {
            InitializeComponent();
            this.pacienteId = Id;
        }

        private void FormFichaPaciente_Load(object sender, EventArgs e)
        {
            cargarDatosPaciente();
        }

        private void cargarDatosPaciente()
        {
            pacienteActual = Crud.PacienteDAO.ObtenerPorId(pacienteId);

            if(pacienteActual == null)
            {
                MessageBox.Show("Paciente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtNombre.Text = pacienteActual.Nombre;
            txtDNI.Text = pacienteActual.DNI;
            txtTelefono.Text = pacienteActual.Telefono;
            txtEdad.Text = pacienteActual.Edad.ToString();
            txtObraSocial.Text = pacienteActual.ObraSocial;
            txtMail.Text = pacienteActual.Mail;
            txtDescripcion.Text = pacienteActual.Descripcion;
        }

        private void btnRecetas_Click(object senderr, EventArgs e)
        {
            var formRecetas = new FormRecetas(pacienteId, pacienteActual.Nombre);
            formRecetas.ShowDialog();

            cargarDatosPaciente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
