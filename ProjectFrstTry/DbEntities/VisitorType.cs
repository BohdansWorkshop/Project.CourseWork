using System.ComponentModel.DataAnnotations;

namespace ProjectFrstTry
{
    public class VisitorType : IdEntity
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        public virtual VisitorType Parent { get; set; }
    }
}