using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Platzi.Models;

namespace Platzi.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuela { get; set; }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // Método que se ejecuta
        {                                               // cuando se está creando la BD.
            base.OnModelCreating(modelBuilder); // Ejecuta el método original y después hago lo que quiero.
            Escuela miEscuela = new Escuela();
            miEscuela.Id = Guid.NewGuid().ToString();
            miEscuela.Nombre = "Platzi";
            miEscuela.AñoDeCreación = 2005;
            miEscuela.Dirección = "Ramón Carrillo 3892";
            miEscuela.Ciudad = "Buenos Aires";
            miEscuela.País = "Argentina";

            // Cargar cursos en Escuela
            var cursos = CargarCursos(miEscuela);

            // Cargar asignaturas al curso
            var asignaturas = CargarAsignaturas(cursos);

            // Cargar alumnos al curso
            var alumnos = CargarAlumnos(cursos);

            // Cargar evaluaciones a alumnos y asignaturas

            modelBuilder.Entity<Escuela>().HasData(miEscuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());


        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            var listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var listaTmp = new List<Asignatura>{
                    new Asignatura() {  Id = Guid.NewGuid().ToString(),
                                        Nombre = "Desarrollo de Aplicaciones con ASP.NET",
                                        CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Carrera de JavaScript", CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Seguridad Informática", CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Bases de Datos", CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Inteligencia Artificial y Machine Learning", CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Escuela de Data Science", CursoId = curso.Id },
                    new Asignatura() { Id = Guid.NewGuid().ToString(), Nombre = "Ingles", CursoId = curso.Id },
                };
                listaCompleta.AddRange(listaTmp);
                //curso.Asignaturas = listaTmp;
            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela miEscuela)
        {
            return new List<Curso>(){
                    new Curso{Nombre = "101",
                              Jornada = TiposJornada.Mañana,
                              EscuelaId = miEscuela.Id,
                              Dirección = "221B Baker Street, London"},
                    new Curso{Nombre = "201", Jornada = TiposJornada.Mañana, EscuelaId = miEscuela.Id, Dirección = "221B Baker Street, London"},
                    new Curso{Nombre = "301", Jornada = TiposJornada.Mañana, EscuelaId = miEscuela.Id, Dirección = "221B Baker Street, London"},
                    new Curso{Nombre = "401", Jornada = TiposJornada.Mañana, EscuelaId = miEscuela.Id, Dirección = "221B Baker Street, London"},
                    new Curso{Nombre = "501", Jornada = TiposJornada.Mañana, EscuelaId = miEscuela.Id, Dirección = "221B Baker Street, London"}
                };
        }

        private static List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();
            var random = new Random();

            foreach (var curso in cursos)
            {
                var tmpList = GenerarAlumnosAlAzar(curso, random.Next(20, 25));
                //curso.Alumnos = tmpList;
                listaAlumnos.AddRange(tmpList);
            }

            return listaAlumnos;
        }

        private static List<Alumno> GenerarAlumnosAlAzar(
                    Curso curso,
                    int cant
                )
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno {  Nombre = $"{n1} {n2} {a1}", 
                                                    Id = Guid.NewGuid().ToString(),
                                                    CursoId = curso.Id };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cant).ToList();
        }
    }
}