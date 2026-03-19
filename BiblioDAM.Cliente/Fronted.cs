


using BiblioDAM.Cliente.Dto;
using System.Threading.Tasks;

namespace BiblioDAM.Cliente

{
    public partial class Fronted : Form
    {
        public readonly ApiClient _ApiClient;
        string rutaSeleccionada="";
        int librosImportados = 0;
        int librosRepetidos = 0;
        int librosErroneos = 0;
        int autoresImportados = 0;
        public Fronted(ApiClient api)

        {
            _ApiClient = api;
            InitializeComponent();
        }



        private  async void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            if(textAutorAdd.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacio");
                return;
            }
            try
                {
                DtoAutores autor = new DtoAutores { nombre = textAutorAdd.Text };
                await _ApiClient.AddAutorAsync(autor);
                MessageBox.Show("Autor añadido correctamente.");

            }
            catch 
            {
                MessageBox.Show("Error al añadir el autor, es posible que ya exista o que el servidor no esté disponible.");

            }




            }

        private async void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            if (txtIsb.Text == "" || txtTituloLibro.Text == "" || txtFechaPublicacion.Text == "" || txtAutorLibro.Text == "")
            {
                MessageBox.Show("Todos los campos deben ser completados.");
                return;
            }
            try { 
                var libro = new DtoLibros
                {
                    Isbn = txtIsb.Text,
                    Titulo = txtTituloLibro.Text,
                    Fecha = txtFechaPublicacion.Text,
                    Autor = txtAutorLibro.Text
                };
                await _ApiClient.AgregarLibroAsync(libro);
                MessageBox.Show("Libro añadido correctamente.");
            }
            catch
            {
                MessageBox.Show("Error al añadir el libro, es posible que el autor no exista o que el servidor no esté disponible.");
            }

        }

        private async void btnImportarCatalago_Click(object sender, EventArgs e)
        {

            librosImportados = 0; // reinicio los contadores 
            librosErroneos = 0;
            autoresImportados = 0;

            OpenFileDialog interaccion = new OpenFileDialog();
            if (interaccion.ShowDialog() == DialogResult.OK)
            {
                rutaSeleccionada = interaccion.FileName;
            }
             

            using (var lector = new StreamReader(rutaSeleccionada))
            {
                string datos;
                while ((datos = lector.ReadLine()) != null)
                {
                    string[] datosSplit = datos.Split(';');
                    if (datosSplit.Length != 4) // si no cumple los criterios de formato
                    {
                        librosErroneos++;
                        continue;
                    }
                   string isbn = datosSplit[0];
                   string titulo = datosSplit[1];
                   string fecha = datosSplit[3];
                   string autorNombre = datosSplit[2];
                    DtoLibros libro = new DtoLibros();
                    libro.Isbn = isbn;
                    libro.Titulo = titulo;
                    libro.Fecha = fecha;
                    libro.Autor = autorNombre;
                    

                    try
                    {
                       var validar =  await _ApiClient.GetLibroByIsbn(isbn);
                        var validarAutor = await _ApiClient.GetLibroByAutorAsync(libro.Autor);
                        if (validar != null)
                        {
                            librosRepetidos++;
                            continue;

                        }
                        else
                        {
                           await  _ApiClient.AgregarLibroAsync(libro); //

                            librosImportados++;
                        }
                        if (validarAutor == null || validarAutor.Count==0) // devuelve una lista, si no encuentra nada devuelve una lista vacia, por eso se valida con count
                        {
                            DtoAutores autor = new DtoAutores();
                            autor.nombre = autorNombre;
                            await  _ApiClient.AddAutorAsync(autor);
                            autoresImportados++;    
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al importar el libro: " + ex.Message);
                        librosErroneos++;
                        continue;
                    }
                }
                ;

                MessageBox.Show(
                    $"Importación finalizada." +
                    $" Libros importados: {librosImportados}. " +
                    $" Libros repetidos: {librosRepetidos}." +
                    $" Libros con errores: {librosErroneos}. " +
                    $" Autores añadidos : {autoresImportados} ");

            }
        }



        

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            Fronted2 pantalla = new Fronted2(_ApiClient);
            pantalla.Show();
            this.Hide();
        }

        private async void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
               await _ApiClient.Testear();
                lblEstadoConexion.Text = " Conexion Abierta";
                lblEstadoConexion.ForeColor = Color.Green;
            }
            catch
            {
                lblEstadoConexion.Text = " Conexion Cerrada";
                lblEstadoConexion.ForeColor = Color.Red;
            }
        }

        }


    }

