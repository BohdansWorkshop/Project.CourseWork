using System.Data.Entity;

namespace ProjectFrstTry
{
    public class VisitorsDbContext : DbContext
    {
       public VisitorsDbContext() : base("HospitalProjectConnection")
        {
            Database.SetInitializer<VisitorsDbContext>(new DbDictionaryInitializer());
            Database.Initialize(true);
        }

        public DbSet<Visitor> Visitors { get; set; }

        public DbSet<VisitorType> VisitorTypes { get; set; }
    }
}