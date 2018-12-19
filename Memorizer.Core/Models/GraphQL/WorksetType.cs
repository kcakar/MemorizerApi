using GraphQL.Types;

namespace Memorizer.Core.Models.GraphQL
{
    public class WorksetType: ObjectGraphType<Workset>
    {
        public WorksetType()
        {
            Name = "Workset";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the workset.");
            Field(x => x.DateCreated, type: typeof(DateTimeGraphType)).Description("Creation date of the workset.");
            Field(x => x.Creator, type: typeof(ListGraphType<UserType>)).Description("Creator of the workset.");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("Name of the workset.");
            Field(x => x.Description, type: typeof(StringGraphType)).Description("Description of the workset.");
            Field(x => x.Questions, type: typeof(ListGraphType<QuestionType>)).Description("Workset questions");
        }
    }
}
