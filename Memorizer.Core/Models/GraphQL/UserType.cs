using System;
using GraphQL.Types;

namespace Memorizer.Core.Models.GraphQL
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = "User";

            Field(x => x.Id, type: typeof(IdGraphType)).Description("The ID of the User.");
            Field(x => x.DateCreated, type: typeof(DateTimeGraphType)).Description("Creation date of the User.");
            Field(x => x.Creator, type: typeof(ListGraphType<UserType>)).Description("Creator of the User.");
            Field(x => x.Name, type: typeof(StringGraphType)).Description("Name of the User.");
            Field(x => x.Surname, type: typeof(StringGraphType)).Description("Surname of the User.");
            Field(x => x.Bio, type: typeof(StringGraphType)).Description("Bio of the User.");
            Field(x => x.AuthType, type: typeof(StringGraphType)).Description("Authorization method of the User.");
            Field(x => x.PictureUrl, type: typeof(StringGraphType)).Description("Picture of the User.");
        }
    }
}
