using Memorizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memorizer.Core.Data
{
    public interface ILanguageRepository
    {
        List<Language> All();
    }
}
