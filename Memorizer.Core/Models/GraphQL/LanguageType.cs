using System;
using GraphQL.Types;

namespace Memorizer.Core.Models.GraphQL
{
    public class LanguageType: ObjectGraphType<Language>
    {
        public LanguageType()
        {
            Name = "Language";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Language.");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("Language Name.");
        }
    }
}