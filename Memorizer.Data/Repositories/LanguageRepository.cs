using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Memorizer.Core.Data;
using Memorizer.Core.Models;

namespace Memorizer.Data.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly MemorizerContext _db;

        public LanguageRepository(MemorizerContext db)
        {
            _db = db;
        }

        public List<Language> All()
        {
            return _db.Languages.ToList();
        }
    }
}
