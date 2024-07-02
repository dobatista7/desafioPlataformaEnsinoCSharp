using desafioPlataformaEnsinoCsharp.entities;

namespace desafioPlataformaEnsinoCsharp.application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Lesson> lessons = new List<Lesson>();

            Console.Write("Quantas aulas tem o curso? ");
            int lessonCount = int.Parse(Console.ReadLine());

            for (int i=1; i <= lessonCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados da {i}ª aula: ");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Título: ");
                string title = Console.ReadLine();

                if (type == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();

                    Console.Write("Duração em segundos: ");
                    int durationInSeconds = int.Parse(Console.ReadLine());

                    lessons.Add(new Video(title, url, durationInSeconds));
                }
                else if (type == 't')
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();

                    Console.Write("Quantidade de questões: ");
                    int questionCount = int.Parse(Console.ReadLine());

                    lessons.Add(new entities.Task(title, description, questionCount));
                }

            }

            int totalDuration = 0;
            foreach (Lesson lesson in lessons)
            {
                totalDuration += lesson.Duration();
            }

            Console.WriteLine();
            Console.WriteLine($"DURAÇÃO TOTAL DO CURSO = {totalDuration} segundos");

        }
    }
}
