using Memorizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memorizer.Core.Data
{
    public interface IUserRepository
    {
        Task<User> Get(int id);
        Task<User> Update(User user);
        Task<User> Delete(User user);
        Task<User> Add(User user);

    }
}
