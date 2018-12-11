using Memorizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memorizer.Core.Data
{
    public interface IWorksetRepository
    {
        Task<Workset> Get(int id);
        Task<List<Workset>> GetAll();
        Task<Workset> Add(Workset workset);
        Task<Workset> Remove(Workset workset);
        Task<Workset> Update(Workset workset);
    }
}
