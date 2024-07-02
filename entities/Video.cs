using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioPlataformaEnsinoCsharp.entities
{
    class Video : Lesson
    {
        public string URL {  get; set; }
        public int DurationInSeconds { get; set; }

        public Video(string title, string url,int durationInSeconds)
            : base(title)
        {
            URL = url;
            DurationInSeconds = durationInSeconds;
        }

        public override int Duration()
        {
            return DurationInSeconds;

        }
    }
}
