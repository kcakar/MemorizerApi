﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class Workset:BaseEntry
    {
        public Workset(User user):base(user)
        {

        }

        public string Name { get; set; }
        public string Description { get; set; } 

        public virtual ICollection<Question> Questions { get; set; }
    }
}
