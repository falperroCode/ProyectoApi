using BiblioDAM.Cliente.Dto;
using BiblioDAM.Core.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioDAM.Cliente
{
    public partial class Fronted2 : Form
    {
        ApiClient _apiClient;
        string isbnSeleccionado = "";
        public Fronted2(ApiClient ApiClient)
        {
            InitializeComponent();
            _apiClient = ApiClient;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool resultado = await _apiClient.EliminarLibroAsync(isbnSeleccionado);
                if (resultado)
                {
                    MessageBox.Show("Libro eliminado correctamente.");
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el libro. Verifique que el ISBN sea correcto.");
                }


            }
            catch
            {
                MessageBox.Show("Error al eliminar el libro. Es posible que el servidor no esté disponible.");
            }




        }
        private async void button2_Click(object sender, EventArgs e)
        {
            dataGridTabla.DataSource = await _apiClient.GetLibrosAsync();

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarByTitulo.Text == "" && txtBuscarByAutor.Text == "")
            {
                MessageBox.Show("Ingrese un título o un autor para buscar.");
                return;
            }

            if (txtBuscarByTitulo.Text != "")
            {
                var libro = await _apiClient.GetLibroByTitulo(txtBuscarByTitulo.Text);
                dataGridTabla.DataSource = libro;
            }

            else if (txtBuscarByAutor.Text != "")
            {
                var libros = await _apiClient.GetLibroByAutorAsync(txtBuscarByAutor.Text);
                dataGridTabla.DataSource = libros;
            }
        }


        #region Eventos
        private void dataGridTabla_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridTabla.CurrentRow;
            if (selectedRow != null)
            {
                var libro = selectedRow.DataBoundItem as DtoLibros;
                isbnSeleccionado = libro.Isbn;
            }
        }



       

      
        #endregion
        public void limpiarCampos()
        {
            txtBuscarByAutor.Clear();
            txtBuscarByTitulo.Clear();
        }

        private void Fronted2_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Owner?.Show(); // Muestra el formulario principal al cerrar este formulario
        }
    }
}
