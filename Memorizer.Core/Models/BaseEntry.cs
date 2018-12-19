using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class BaseEntry
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }

        public User Creator { get; set; }
    }
}
