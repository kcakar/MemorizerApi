using System;
namespace Memorizer.Core.Models
{
    public class Base
    {
        public Base()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
