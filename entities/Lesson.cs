using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioPlataformaEnsinoCsharp.entities
{
    abstract class Lesson
    {
        public string Title { get; set; }
        protected Lesson(string title)
        {
            Title = title;
        
        }
        public abstract int Duration();
    }
}
