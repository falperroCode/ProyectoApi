using Azure;
using BiblioDAM.Cliente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BiblioDAM.Cliente
{
    public class ApiClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private bool _disposed;


        public ApiClient(string baseUrl)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _disposed = false;
        }
        /// LIBROS
        /// 

        //metodos get

        public async Task<List<DtoLibros>> GetLibrosAsync()
        {
            var llamada = await _httpClient.GetAsync("api/Libro");
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadFromJsonAsync<List<DtoLibros>>() ?? new List<DtoLibros>();
        }



        public async Task<List<DtoLibros>> GetLibroByAutorAsync(string autor)
        {
            var llamada = await _httpClient.GetAsync($"api/Libro/Autor/{autor}");
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadFromJsonAsync<List<DtoLibros>>() ?? new List<DtoLibros>();

        }

        public async Task<List<DtoLibros>> GetLibroByTitulo(String titulo)
        {
            var llamada = await _httpClient.GetAsync($"api/Libro/Titulo/{titulo}");
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadFromJsonAsync<List<DtoLibros>>() ?? new List<DtoLibros>();

        }
        public async Task<DtoLibros> GetLibroByIsbn(String isbn)
        {
            var llamada = await _httpClient.GetAsync($"api/Libro/Isbn/{isbn}");
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadFromJsonAsync<DtoLibros>() ?? new DtoLibros();

        }


        public async Task Testear()
        {
            var llamada = await _httpClient.GetAsync($"api/Libro/Testear/");
            llamada.EnsureSuccessStatusCode();
            var respuesta = await llamada.Content.ReadAsStringAsync();
            MessageBox.Show(respuesta);
        }
        /// metodos post
        /// 

        public async Task<string> AgregarLibroAsync(DtoLibros libro)
        {
            var llamada = await _httpClient.PostAsJsonAsync("api/Libro", libro);
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadAsStringAsync();
        }

        ///metodo delete
        /// 
        public async Task<bool> EliminarLibroAsync(string isbn)
        {
            var llamada = await _httpClient.DeleteAsync($"api/Libro/{isbn}");
            if (llamada.IsSuccessStatusCode)
            {
                await llamada.Content.ReadAsStringAsync();
                return true;
            }
            else
            {
                return false;

            }

        }

        //// AUTORES 
        ///


        //METODO POST

        public async Task<string> AddAutorAsync(DtoAutores dto)
        {
            var llamada = await _httpClient.PostAsJsonAsync($"api/Autores", dto);
            llamada.EnsureSuccessStatusCode();
            return await llamada.Content.ReadAsStringAsync();
        }


        // METODO DE DESTRUCCION
        public void Dispose()
        {
            if (!_disposed)
            {
                _httpClient.Dispose();
                _disposed = true;
            }
        }
    }
}
