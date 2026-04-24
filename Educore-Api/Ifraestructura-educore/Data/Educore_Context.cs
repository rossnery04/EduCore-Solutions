using Domain_educore.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Ifraestructura_educore.Data
{
    public class Educore_Context: DbContext
    {
        public Educore_Context(DbContextOptions o): base(o)
        {  
        }

        public DbSet<Workshop> workshops { get; set; }
        public DbSet<Students> students { get; set; }
        public DbSet<instructors> Instructors { get; set; }
        public DbSet<Resgistrations> resgistrations { get; set; }
        public DbSet<attedance> attendances { get; set; }
    }

}
