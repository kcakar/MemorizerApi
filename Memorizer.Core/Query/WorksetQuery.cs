using GraphQL.Types;
using Memorizer.Data;
using Memorizer.Core.Models.GraphQL;
using System;

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

                        return null;
                    }
                );
        }
    }
}
