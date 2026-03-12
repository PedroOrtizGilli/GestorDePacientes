using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static GestorDePaciente.Crud;

namespace GestorDePaciente
{
    public partial class FormNuevoPaciente : Form
    {
        private int pacienteIdCreado = 0;
        public FormNuevoPaciente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEdad.Text) || !int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad es obligatoria y debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdad.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtObraSocial.Text))
            {
                MessageBox.Show("La obra social es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtObraSocial.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                MessageBox.Show("El mail es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMail.Focus();
                return;
            }

            try
            {
                var nuevoPaciente = new Paciente
                {
                    Nombre = txtNombre.Text.Trim(),
                    DNI = string.IsNullOrWhiteSpace(txtDNI.Text) ? null : txtDNI.Text.Trim(),
                    ObraSocial = string.IsNullOrWhiteSpace(txtObraSocial.Text) ? null : txtObraSocial.Text.Trim(),
                    Mail = string.IsNullOrWhiteSpace(txtMail.Text) ? null : txtMail.Text.Trim(),
                    Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                    Edad = string.IsNullOrWhiteSpace(txtEdad.Text) ? 0 : int.Parse(txtEdad.Text.Trim()),
                    Descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()
                };

                pacienteIdCreado = Crud.PacienteDAO.Insertar(nuevoPaciente);

                MessageBox.Show("Paciente creado exitosamente con ID: " + pacienteIdCreado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnAgregarRecetas.Enabled = true;
                btnCrear.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarRecetas_Click(object sender, EventArgs e)
        {
            if (pacienteIdCreado == 0)
            {
                MessageBox.Show("No se ha creado un paciente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var formRecetas = new FormRecetas(pacienteIdCreado, txtNombre.Text);
            formRecetas.ShowDialog();
        }

        private void FormNuevoPaciente_Load(object sender, EventArgs e)
        {
            btnAgregarRecetas.Enabled = false;
            txtNombre.Focus();
        }

    }
}
