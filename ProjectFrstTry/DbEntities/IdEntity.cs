using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectFrstTry
{
    public class IdEntity
    {
        public IdEntity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; protected set; }
    }
}