using System.ComponentModel.DataAnnotations;
using System;
namespace Torneo.App.Dominio
{
   
    public class Municipio
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del Municipio")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        
    }
}