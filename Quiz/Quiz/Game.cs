using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    // 100, 200, 300, 400, 500, 750, 1000


    public class Game
    {
        public Game()
        {
            CreateQuestions();
            Random = new Random();
            Categories = Questions
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            CurrentCategory = Categories[CurrentCategoryIndex];
        }


        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Random Random { get; set; }
        public Question CurrentQuestion { get; set; }
        public List<int> Categories { get; set; }
        public int CurrentCategoryIndex { get; set; }

        private void CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";;
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        public void GetQuestion()
        {
            var qC = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, qC.Count);
            var question = qC[number];
            question.Answers = question.Answers.OrderBy(x => x.Content).ToList();

            var index = 1;
            foreach (var answer in question.Answers)
            {
                answer.Order = index;
                index++;
            }
                      
            CurrentQuestion = question;
        }


        public bool CheckPlayerAnswer(int playerNumber)
        {
            var answer = CurrentQuestion.Answers.FirstOrDefault(x => x.Order == playerNumber);
            return answer.IsCorrect;
        }

        public bool IsLastCategory()
        {
            // jeżeli to nie jest ostatnia kategoria, to podnosimy kategorię na następną
            // i zwracamy false
            if (CurrentCategoryIndex < Categories.Count - 1)
            {
                CurrentCategoryIndex++;
                CurrentCategory = Categories[CurrentCategoryIndex];
                return false;
            }
          
            return true;
            
        }
    }
}
