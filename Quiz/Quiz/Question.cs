using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }

        void ShowQuestion()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Pytanie za {Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(Content);
            Console.WriteLine();
            foreach (var answer in Answers)
            {
                Console.WriteLine($"{answer.Order}. {answer.Content}");
            }
            Console.WriteLine();
            Console.Write("Naciśnij numer prawidłowej odpowiedzi: 1, 2, 3 lub 4 => ");
        }


        public int DisplayQuestion()
        {
            ShowQuestion();
            var answer = Console.ReadLine();
            while(!IsCoorectKey(answer))
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wcisnąłeś nieprawidłowy klawisz ...");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                ShowQuestion();
                answer= Console.ReadLine();
                Console.WriteLine();
                
            }

            return int.Parse(answer);

        }

        bool IsCoorectKey(string key)
        {
            int.TryParse(key, out int number);
            if (number > 0 && number < 5)
                return true;

            return false;
        }


    }
}
