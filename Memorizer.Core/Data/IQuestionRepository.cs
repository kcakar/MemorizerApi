using Memorizer.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Memorizer.Core.Data
{
    public interface IQuestionRepository
    {
        Task<Question> Get(int id);
        Task<List<Question>> GetAllByWorksetId(int id);
        Task<Question> Add(Question question);
        Task<Question> Remove(Question question);
        Task<Question> Update(Question question);
    }
}
