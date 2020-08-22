using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platzi.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage="This field is required.***")]
        [StringLength(5)]
        public override string Nombre { get; set; } // Sobreescribo el campo virtual de la
        // clase padre
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Required(ErrorMessage="A course needs to have an address.***")]
        [MinLength(10,ErrorMessage="The minimum length is 10.***")]
        public string Dirección { get; set; }

    }
}