using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class BaseEntry:Base
    {
        public BaseEntry(User creator)
        {
            Creator = creator;
        }
        public User Creator { get; set; }
    }
}
