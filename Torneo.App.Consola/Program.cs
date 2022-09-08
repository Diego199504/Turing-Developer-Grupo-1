using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using System;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDirectorTecnico _repoDt = new RepositorioDirectorTecnico();
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1. Insertar Municipio");
                Console.WriteLine("2. Insertar Director Tecnico");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Seleccione la opcion deseada");
                opcion = Int32.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddDirectorTecnico();
                        break;

                }
            } while (opcion != 0);
        }

        private static void AddMunicipio()
        {
            Console.WriteLine("Ingrese el nombre del Municipio");
            string nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void AddDirectorTecnico()
        {
            Console.WriteLine("Ingrese el nombre del Municipio");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del Documento de Identificacion");
            int documento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del telefono");
            int telefono = Convert.ToInt32(Console.ReadLine());
            var dt = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,
            };
            _repoDt.AddDirectorTecnico(dt);
        }

    }
}
