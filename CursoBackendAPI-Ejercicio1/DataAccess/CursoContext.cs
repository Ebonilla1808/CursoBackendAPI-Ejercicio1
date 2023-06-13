using CursoBackendAPI_Ejercicio1.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CursoBackendAPI_Ejercicio1.DataAccess
{
    public class CursoContext: DbContext
    {
        public CursoContext(DbContextOptions<CursoContext> options) : base(options)
        {
        }

        //TODO: Add DbSets (Tables of our Database)

        public DbSet<Curso>? Cursos { get; set; }
    }
}
