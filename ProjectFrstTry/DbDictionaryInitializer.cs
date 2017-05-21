using System.Data.Entity;

namespace ProjectFrstTry
{
    public class DbDictionaryInitializer : CreateDatabaseIfNotExists<VisitorsDbContext>
    {
        protected override void Seed(VisitorsDbContext context)
        {
            VisitorType Unassigned = new VisitorType() { Name = "Unassigned" };
            VisitorType Consultation = new VisitorType { Name = "Consultation" };
            VisitorType IllVisitor = new VisitorType { Name = "Ill Visitor" };

            context.VisitorTypes.Add(Unassigned);
            context.VisitorTypes.Add(Consultation);
            context.VisitorTypes.Add(IllVisitor);
       

            //base.Seed(context);
        }
    }
}