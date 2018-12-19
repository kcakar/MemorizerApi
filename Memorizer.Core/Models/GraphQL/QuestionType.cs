using System;
using GraphQLParser.AST;
using GraphQL.Types;
namespace Memorizer.Core.Models.GraphQL
{
    public class QuestionType:ObjectGraphType<Question>
    {
        public QuestionType()
        {
            Name = "Question";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the Question.");
            Field(x => x.DateCreated, type: typeof(DateTimeGraphType)).Description("Creation date of the Question.");
            Field(x => x.Creator, type: typeof(ListGraphType<UserType>)).Description("Creator of the Question.");

            Field(x => x.QuestionText, type: typeof(StringGraphType)).Description("Question.");
            Field(x => x.Answer, type: typeof(StringGraphType)).Description("Answer.");
            Field(x => x.QuestionLanguage, type: typeof(LanguageType)).Description("The language of the question.");
            Field(x => x.AnswerLanguage, type: typeof(LanguageType)).Description("The language of the answer.");
            Field(x => x.WorksetId, type: typeof(IdGraphType)).Description("The ID of the Workset that includes this question.");
        }
    }
}
