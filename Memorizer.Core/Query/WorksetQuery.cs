using GraphQL.Types;
using Memorizer.Data;
using Memorizer.Core.Models.GraphQL;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Memorizer.Api.Query
{
    public class WorksetQuery: ObjectGraphType
    {
        public WorksetQuery(MemorizerContext db)
        {
            Field<WorksetType>(
                "workset",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IdGraphType> { Name = "id", Description = "The Id of the Workset" }
                    ),
                resolve:
                    context =>
                    {
                        var id = context.GetArgument<Guid?>("id");
                        var workset = db.Worksets.Include(x => x.Questions).FirstOrDefault(i=>i.Id==id);
                        return workset;
                    }
                );

            Field<ListGraphType<WorksetType>>(
                "worksets",
                resolve:
                    context =>
                    {
                        var worksets = db.Worksets
                            .Include(x => x.Questions)
                                .ThenInclude(q => q.AnswerLanguage)
                            .Include(x => x.Questions)
                                .ThenInclude(q => q.QuestionLanguage);
                        return worksets;
                    }
                );
        }
    }
}
