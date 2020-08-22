using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        [Required]
        [StringLength(20)]
        public override string Nombre { get; set; } // Sobreescribo el campo virtual de la
        // clase padre
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}