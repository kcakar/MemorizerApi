using System;
using Memorizer.Data;
using Microsoft.EntityFrameworkCore.Internal;
using Memorizer.Core.Models;
using System.Collections.Generic;
using System.Linq;
namespace Memorizer.Core
{
    public class DataSeed
    {
        public static void Run(MemorizerContext db)
        {
            User user = new User();
            user.Name = "Keremcan";
            user.Surname = "Çakar";
            user.PictureUrl = "";

            if (!db.Languages.Any())
            {
                db.Languages.Add(new Language()
                {
                    Name="German"
                });

                db.Languages.Add(new Language()
                {
                    Name = "Turkish"
                });

                db.Languages.Add(new Language()
                {
                    Name = "English"
                });
                db.SaveChanges();
            }

            if (!db.Worksets.Any())
            {
                db.Worksets.Add(
                new Workset(user)
                {
                     Name="Kerem's German Workset",
                     Description="Memorize Basic German words and structures",
                     Questions= new List<Question>
                     {
                         new Question(user)
                         {
                             QuestionText="Mädchen",
                             Answer="Girl",
                             QuestionLanguage=db.Languages.FirstOrDefault(x=>x.Name=="German"),
                             AnswerLanguage=db.Languages.FirstOrDefault(x=>x.Name=="English"),
                         },
                         new Question(user)
                         {
                             QuestionText="Wasser",
                             Answer="Water",
                             QuestionLanguage=db.Languages.FirstOrDefault(x=>x.Name=="German"),
                             AnswerLanguage=db.Languages.FirstOrDefault(x=>x.Name=="English"),
                         },
                         new Question(user)
                         {
                             QuestionText="Brot",
                             Answer="Bread",
                             QuestionLanguage=db.Languages.FirstOrDefault(x=>x.Name=="German"),
                             AnswerLanguage=db.Languages.FirstOrDefault(x=>x.Name=="English"),
                         }
                     }

                });
                db.SaveChanges();
            }
        }
    }
}
