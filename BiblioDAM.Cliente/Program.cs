using Microsoft.Extensions.Configuration;
namespace BiblioDAM.Cliente
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true)
            .Build();

            var apiBaseUrl = configuration["ApiSettings:BaseUrl"] ?? "http://localhost:5000";
            using var ApiClient = new ApiClient(apiBaseUrl);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Fronted(ApiClient));
        }
    }
}