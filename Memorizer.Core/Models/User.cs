using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class User:BaseEntry
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public string AuthType { get; set; }
        public string PictureUrl { get; set; }
    }
}
