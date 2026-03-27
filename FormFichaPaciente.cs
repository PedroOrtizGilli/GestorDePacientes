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
        private bool modoEdicion = false;
        public FormFichaPaciente(int Id)
        {
            InitializeComponent();
            this.pacienteId = Id;
        }

        private void FormFichaPaciente_Load(object sender, EventArgs e)
        {
            cargarDatosPaciente();
            txtNombre.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtObraSocial.ReadOnly = true;
            txtMail.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
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

            txtNombre.Text = pacienteActual.Nombre ?? "";
            txtDNI.Text = pacienteActual.DNI ?? "";
            txtTelefono.Text = pacienteActual.Telefono ?? "";
            txtEdad.Text = pacienteActual.Edad.ToString();
            txtObraSocial.Text = pacienteActual.ObraSocial ?? "";
            txtMail.Text = pacienteActual.Mail ?? "";
            txtDescripcion.Text = pacienteActual.Descripcion ?? "";

            label8.Text = $"Ficha de {pacienteActual.Nombre}";
        }

        private void btnRecetas_Click(object senderr, EventArgs e)
        {
            var formRecetas = new FormRecetas(pacienteId, pacienteActual.Nombre);
            formRecetas.ShowDialog();

            cargarDatosPaciente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!modoEdicion)
            {
                // Activar modo edición
                modoEdicion = true;
                btnActualizar.Text = "Guardar";

                txtNombre.ReadOnly = false;
                txtDNI.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtEdad.ReadOnly = false;
                txtObraSocial.ReadOnly = false;
                txtMail.ReadOnly = false;
                txtDescripcion.ReadOnly = false;
            }
            else
            {
                // Guardar cambios
                pacienteActual.Nombre = txtNombre.Text;
                pacienteActual.DNI = txtDNI.Text;
                pacienteActual.Telefono = txtTelefono.Text;
                pacienteActual.Edad = int.Parse(txtEdad.Text);
                pacienteActual.ObraSocial = txtObraSocial.Text;
                pacienteActual.Mail = txtMail.Text;
                pacienteActual.Descripcion = txtDescripcion.Text;

                bool actualizado = Crud.PacienteDAO.Actualizar(pacienteActual);

                if (actualizado)
                {
                    MessageBox.Show("Paciente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modoEdicion = false;
                    btnActualizar.Text = "Actualizar";
                    cargarDatosPaciente();

                    txtNombre.ReadOnly = true;
                    txtDNI.ReadOnly = true;
                    txtTelefono.ReadOnly = true;
                    txtEdad.ReadOnly = true;
                    txtObraSocial.ReadOnly = true;
                    txtMail.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
