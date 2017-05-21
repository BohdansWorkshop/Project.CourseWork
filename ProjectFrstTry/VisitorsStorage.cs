using System.Collections.Generic;

namespace ProjectFrstTry
{
    public static class VisitorsStorage
    {
        static VisitorsStorage ()
        {
            Visitors = new List<Visitor>();
        }
         public static List<Visitor> Visitors { get; set; } 
    }
}