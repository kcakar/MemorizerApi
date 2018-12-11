using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class Workset:BaseEntry
    {
        public string Name { get; set; }
        public string Description { get; set; } 

        public virtual List<Question> Questions { get; set; }
    }
}
