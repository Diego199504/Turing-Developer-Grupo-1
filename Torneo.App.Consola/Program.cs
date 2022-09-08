﻿using Torneo.App.Dominio;
using Torneo.App.Persistencia;
using System;
namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioPosicion _repoPosiciones = new RepositorioPosicion();

        static void Main(string[] args)
        {
            int Opcion = 0;
            do
            {
                Console.WriteLine("1. Insertar Municipio");
                Console.WriteLine("2. Insertar Director Tecnico");
                Console.WriteLine("3. Insertar Director Equipo");
                Console.WriteLine("4. Insertar Posicion");
                Console.WriteLine("5. Mostrar lista Municipio");
                Console.WriteLine("6. Mostrar lista Director Tecnico");
                Console.WriteLine("7. Mostrar lista Equipos");
                Console.WriteLine("8. Mostrar lista Posicion");
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
                            GetAllMunicipios();
                            break;
                    case 6:
                            GetAllDirectoresTecnicos();
                            break;
                    case 7:
                            GetAllEquipos();
                            break;
                    case 8:
                            GetAllPosicion();
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
            string documento = (Console.ReadLine());
            Console.WriteLine("Ingrese numero de Telefono");
            string telefono = (Console.ReadLine());
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
            int idDirectorTecnico =  Int32.Parse(Console.ReadLine());
            var equipo = new Equipo
            {
                Nombre = nombre,
            };
            _repoEquipo.AddEquipo(equipo,idMunicipio,idDirectorTecnico);
        }
        private static void AddPosicion()
        {
            Console.WriteLine("Ingrese la posición del Jugador");
            string nombre = Console.ReadLine();
            var posicion = new Posicion
            {
                Nombre = nombre,
            };
            _repoPosiciones.AddPosicion(posicion);
        }
        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                
                Console.WriteLine(" ID Municipio: "+municipio.Id + " " + "Nombre:" + municipio.Nombre);
            }
        }
        private static void GetAllEquipos()
        {
            foreach (var equipo in _repoEquipo.GetAllEquipos())
            {
                
                Console.WriteLine("ID Equipo:"+ equipo.Id + " " + "Nombre:" +equipo.Nombre + " " + "Municipio: " + equipo.Municipio.Nombre 
                + " " + "DT:" + equipo.DirectorTecnico.Nombre);
            }
        }
        private static void GetAllDirectoresTecnicos()
        {
            foreach (var directorTecnico in _repoDirectorTecnico.GetAllDirectoresTecnicos())
            {
                
                Console.WriteLine("ID DT:"+directorTecnico.Id + " " +"Nombre: "+ directorTecnico.Nombre + " " +
                "Documento: " +directorTecnico.Documento + " " + "Telefono: "+ directorTecnico.Telefono);
            }
        }
        private static void GetAllPosicion()
        {
            foreach (var posicion in _repoPosiciones.GetAllPosicion())
            {
                
                Console.WriteLine(" ID Posicion: "+posicion.Id + " " + "Nombre:" + posicion.Nombre);
            }
        }
    }
}