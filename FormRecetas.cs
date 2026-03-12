using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestorDePaciente
{
    public partial class FormRecetas : Form
    {
        private int pacienteId;
        private string nombrePaciente;

        public FormRecetas(int id, string nombre)
        {
            InitializeComponent();
            this.pacienteId = id;
            this.nombrePaciente = nombre;
        }

        private void FormRecetas_Load(object sender, EventArgs e)
        {
            lblNombrePaciente.Text = $"Recetas de {nombrePaciente}";
            CargarRecetas();
        }

        private void CargarRecetas()
        {
            var recetas = Crud.RecetaDAO.ObtenerPorPaciente(pacienteId);
            listBoxRecetas.Items.Clear();
            listBoxRecetas.DisplayMember = "Display";

            foreach (var receta in recetas)
            {
                listBoxRecetas.Items.Add(new RecetaDisplay
                {
                    Receta = receta,
                    Display = $"{receta.FechaEmision:dd/MM/yyyy} - {receta.Descripcion ?? receta.NombreArchivo}"
                });
            }

            lblTotal.Text = $"Total de recetas: {recetas.Count}";
        }

        private class RecetaDisplay
        {
            public Crud.Receta Receta { get; set; }
            public string Display { get; set; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";
            dialog.Title = "Seleccionar receta";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var receta = new Crud.Receta
                    {
                        PacienteId = pacienteId,
                        NombreArchivo = System.IO.Path.GetFileName(dialog.FileName),
                        FechaEmision = DateTime.Now
                    };

                    int id = Crud.RecetaDAO.Insertar(receta, dialog.FileName);

                    MessageBox.Show($"Receta agregada exitosamente con Id: {id}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRecetas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar receta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listBoxRecetas_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxRecetas.SelectedItem != null)
            {
                var seleccionado = (RecetaDisplay)listBoxRecetas.SelectedItem;
                Crud.RecetaDAO.AbrirArchivo(seleccionado.Receta.Id);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxRecetas.SelectedItems == null)
            {
                MessageBox.Show("Seleccione al menos una receta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = MessageBox.Show("¿Está seguro de que desea eliminar las recetas seleccionadas?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                var seleccionado = (RecetaDisplay)listBoxRecetas.SelectedItem;

                if(Crud.RecetaDAO.Eliminar(seleccionado.Receta.Id))
                {
                    MessageBox.Show("Receta eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRecetas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la receta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
