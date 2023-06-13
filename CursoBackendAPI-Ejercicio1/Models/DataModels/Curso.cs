
using System.ComponentModel.DataAnnotations;
namespace CursoBackendAPI_Ejercicio1.Models.DataModels
{
    public class Curso
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required, StringLength(int.MaxValue)]
        public string Nombre { get; set; }

        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; }

        [Required]
        public string DescripcionLarga { get; set; }

        [Required]
        public string PublicoObjetivo { get; set; }

        [Required]
        public string Objetivos { get; set; }

        [Required]
        public string Requisitos { get; set; }

        [Required]
        public int Nivel { get; set; }
    }
}
