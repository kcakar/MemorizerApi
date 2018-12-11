using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class BaseEntry
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }

        public User Creator { get; set; }
    }
}
