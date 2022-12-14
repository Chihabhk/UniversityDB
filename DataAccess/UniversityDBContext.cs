using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAcess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }

        //Add DbSets (Tables of our Database)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
