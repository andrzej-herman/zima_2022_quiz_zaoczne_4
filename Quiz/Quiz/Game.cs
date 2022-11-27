using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        public Game()
        {
            CreateQuestions();
            CurrentCategory = 100;
            Random = new Random();
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Random Random { get; set; }
        public Question CurrentQuestion { get; set; }

        private void CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";;
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        public void GetQuestion()
        {
            var qC = new List<Question>();
            foreach (var question in Questions)
            {
                if (question.Category == CurrentCategory)
                {
                    qC.Add(question);   
                }
            }

            var number = Random.Next(0, qC.Count);
            CurrentQuestion = qC[number];
        }
    }
}
