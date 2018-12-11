using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Core.Models
{
    public class Question
    {
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        public Language QuestionLanguage { get; set; }
        public Language AnswerLanguage { get; set; }
        public Workset Workset { get; set; }
    }
}
