using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Tarea_4.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Este campo obligatorio")]
        public long cedula { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public long telefono { get; set; }

        public string correo { get; set; }

        public string genero { get; set; }

        public string cargo { get; set; }

        public string imagen { get; set; }

    }
}