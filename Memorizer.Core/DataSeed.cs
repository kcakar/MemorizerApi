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
            if (!db.Languages.Any())
            {
                db.Languages.Add(new Language()
                {
                    Id=Guid.NewGuid(),
                    Name="German"
                });

                db.Languages.Add(new Language()
                {
                    Id = Guid.NewGuid(),
                    Name = "Turkish"
                });

                db.Languages.Add(new Language()
                {
                    Id = Guid.NewGuid(),
                    Name = "English"
                });
                db.SaveChanges();
            }

            if (!db.Worksets.Any())
            {
                db.Worksets.Add(
                new Workset()
                {
                    Id = Guid.NewGuid(),
                    DateCreated = DateTime.Now,
                     Name="Kerem's German Workset",
                     Description="Memorize Basic German words and structures",
                     Questions= new List<Question>
                     {
                         new Question()
                         {
                             Id=Guid.NewGuid(),
                             DateCreated=DateTime.Now,
                             QuestionText="Mädchen",
                             Answer="Girl",
                             QuestionLanguage=db.Languages.FirstOrDefault(x=>x.Name=="German"),
                             AnswerLanguage=db.Languages.FirstOrDefault(x=>x.Name=="English"),
                         },
                         new Question()
                         {
                             Id=Guid.NewGuid(),
                             DateCreated=DateTime.Now,
                             QuestionText="Wasser",
                             Answer="Water",
                             QuestionLanguage=db.Languages.FirstOrDefault(x=>x.Name=="German"),
                             AnswerLanguage=db.Languages.FirstOrDefault(x=>x.Name=="English"),
                         },
                         new Question()
                         {
                             Id=Guid.NewGuid(),
                             DateCreated=DateTime.Now,
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
