using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectFrstTry
{
    public  class Visitor : IdEntity
    {
        public Visitor()
        {
           
        }
        public string Name { get; set; }
        public VisitorDestination Destination { get; set; }
        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        public DateTime editedTime { get; set; }
       
        public virtual VisitorType Type { get; set; }

        public override string ToString()
        {
            return $"{Name} {Destination} {Type}";
        }
    }
}