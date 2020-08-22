using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Platzi.Models;

namespace Platzi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host = CreateHostBuilder(args).Build(); // Creo mi servidor, pero no lo ejecuto
            using (var scope = host.Services.CreateScope()) // Con scope accedo a los servicios
            // Uso el using para que la variable scope después de que termine el bloque sea eliminada.
            {
                var services = scope.ServiceProvider; // Llamo a los servicios
                try // Manejo el error en caso de que no pueda conectarse a la base de datos.
                {
                    var context = services.GetRequiredService<EscuelaContext>(); // Ahora tengo acceso a la BD
                    context.Database.EnsureCreated(); // Pido que asegure que la BD esté creada, invoca el método OnModelCreating
                }
                catch (Exception ex)
                { // Guardo los errores en un log
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Ocurrio un error");
                }
            }
            host.Run(); // El server no inicia hasta que esté la BD cargada.
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
