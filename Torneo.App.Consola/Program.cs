using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using System;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioPosicion _repoPosicion = new RepositorioPosicion();
        private static IRepositorioPartido _repoPartido = new RepositorioPartido();
        
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        static void Main(string[] args)
        {
            int Opcion = 0;
            do
            {
                Console.WriteLine("1. Insertar Municipio");
                Console.WriteLine("2. Insertar Director Tecnico");
                Console.WriteLine("3. Insertar Equipo");
                Console.WriteLine("4. Insertar Posicion");
                Console.WriteLine("5. Insertar Partido");
                Console.WriteLine("6. Insertar Jugador");
                Console.WriteLine("7. Mostrar lista Municipio");
                Console.WriteLine("8. Mostrar lista Director Tecnico");
                Console.WriteLine("9. Mostrar lista Equipos");
                Console.WriteLine("10. Mostrar lista Posicion");
                Console.WriteLine("11. Mostrar lista Partido");
                Console.WriteLine("12. Mostrar Jugador");
                Console.WriteLine("0. Salir");
                Opcion = Convert.ToInt32(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        AddMunicipio();
                        break;
                    case 2:
                        AddDT();
                        break;
                    case 3:
                        AddEquipo();
                        break;
                    case 4:
                        AddPosicion();
                        break;
                    case 5:
                        AddPartido();
                        break;
                    case 6:
                        AddJugador();
                         break;    
                    case 7:
                        GetAllMunicipios();
                        break;
                    case 8:
                        GetAllDirectoresTecnicos();
                        break;
                    case 9:
                        GetAllEquipos();
                        break;
                    case 10:
                        GetAllPosiciones();
                        break;
                    case 11:
                        GetAllPartidos();
                        break;
                    case 12:
                        GetAllJugadores();
                        break;     
                            
                }
            }
            while (Opcion != 0);
        }

        private static void AddMunicipio()
        {
            Console.WriteLine("Ingrese Nombre del Municipio");
            string nombre = Console.ReadLine();
            var municipio = new Municipio
            {
                Nombre = nombre,
            };
            _repoMunicipio.AddMunicipio(municipio);
        }


        private static void AddDT()
        {
            Console.WriteLine("Ingrese nombre del DT");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese numero de Documento del DT");
            int documento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero de Telefono");
            int telefono = Convert.ToInt32(Console.ReadLine());
            var directorTecnico = new DirectorTecnico
            {
                Nombre = nombre,
                Documento = documento,
                Telefono = telefono,

            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);
        }

        private static void AddEquipo()
        {
            Console.WriteLine("Ingrese nombre del Equipo");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo del Municipio");
            int idMunicipio = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo del DT");
            int idDirectorTecnico = Int32.Parse(Console.ReadLine());
            var equipo = new Equipo
            {
                Nombre = nombre,
            };
            _repoEquipo.AddEquipo(equipo, idMunicipio, idDirectorTecnico);
        }
        private static void AddPosicion()
        {
            Console.WriteLine("Ingrese una posición");
            string nombre = Console.ReadLine();
            var posicion = new Posicion
            {
                Nombre = nombre,
            };
            _repoPosicion.AddPosicion(posicion);
        }

        private static void AddPartido()
        {
            Console.WriteLine("Ingrese nombre del Hora del partido con el siguiente formato DD/MM/AAAA HH:MM:SS AM/PM");
            DateTime tiempo = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo del Equipo Local");
            int idEquipoLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo del Equipo Visitante");
            int idEquipoVisitante = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Marcador Equipo Local");
            int marcaLocal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Marcador Equipo Visitante");
            int marcaVisitante = Int32.Parse(Console.ReadLine());
            var partido = new Partido
            {
                FechaHora = tiempo,
                MarcadorEquipoLocal = marcaLocal,
                MarcadorEquipoVisitante = marcaVisitante
            };
            _repoPartido.AddPartido(partido, idEquipoLocal, idEquipoVisitante);
        }

            private static void AddJugador()
         {
                Console.WriteLine(" Ingrese el nombre del Jugador ");
                string nombre = Console.ReadLine();
                Console.WriteLine(" Ingrese el numero del Jugador ");
                int numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese Id Posicion ");
                int idPosicion = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese Id el Equipo ");
                int idEquipo = Int32.Parse(Console.ReadLine());
                var jugador = new Jugadores
            
                {
                    Nombre = nombre,
                    Numero = numero,
                    
                };
                _repoJugador.AddJugador(jugador, idPosicion,idEquipo);
        }       
        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {

                Console.WriteLine(" ID Municipio: " + municipio.Id + " " + "Nombre:" + municipio.Nombre);
            }
        }
        private static void GetAllEquipos()
        {
            foreach (var equipo in _repoEquipo.GetAllEquipos())
            {

                Console.WriteLine("ID Equipo:" + equipo.Id + " " + "Nombre:" + equipo.Nombre + " " + "Municipio: " + equipo.Municipio.Nombre
                + " " + "DT:" + equipo.DirectorTecnico.Nombre);
            }
        }
        private static void GetAllDirectoresTecnicos()
        {
            foreach (var directorTecnico in _repoDirectorTecnico.GetAllDirectoresTecnicos())
            {

                Console.WriteLine("ID DT:" + directorTecnico.Id + " " + "Nombre: " + directorTecnico.Nombre + " " +
                "Documento: " + directorTecnico.Documento + " " + "Telefono: " + directorTecnico.Telefono);
            }
        }
        private static void GetAllPosiciones()
        {
            foreach (var posicion in _repoPosicion.GetAllPosiciones())
            {

                Console.WriteLine(" ID Posicion: " + posicion.Id + " " + "Nombre:" + posicion.Nombre);
            }
        }

        private static void GetAllPartidos()
        {
            foreach(var partido in _repoPartido.GetAllPartidos())
            {
                Console.WriteLine("ID Partido: " + partido.Id + " " +"Fecha del Partido :" + partido.FechaHora + " " + "Equipo Local :" + partido.Local.Nombre + " " +  "Marcador Local : " + partido.MarcadorEquipoLocal + " " + "Equipo Visitante : " + " " + partido.Visitante.Nombre + " " + "Marcador Visitante : " + partido.MarcadorEquipoVisitante);
            }
        }
         private static void GetAllJugadores()
        {
            foreach (var jugador in _repoJugador.GetAllJugadores())
            {
            Console.WriteLine(jugador.Id + " " + jugador.Nombre + " " + jugador.Numero  + " "  + jugador.Posicion.Nombre  + " " + jugador.Equipo.Nombre);
            }
        }
    }
}