using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioPlataformaEnsinoCsharp.entities
{
    class Task : Lesson
    {
        public string Description { get; set; }
        public int QuestionCount { get; set; }

        public Task(string title,string description, int questionCount)
            :base(title)
        {
            Description = description;
            QuestionCount = questionCount;
        }

        public override int Duration()
        {
            return QuestionCount * 5 * 60;
        }
    }
}
