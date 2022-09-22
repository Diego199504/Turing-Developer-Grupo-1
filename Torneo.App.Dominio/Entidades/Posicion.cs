using System;
using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class Posicion
    {
       public int Id { get; set;} 
       [Display(Name = "Nombre de la Posicion")]
       public string Nombre  { get; set;} 
       public List<Jugadores> Jugadores {get;set;}
    }
}