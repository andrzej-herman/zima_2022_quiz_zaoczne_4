using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Witamy w Quizie gr 4");
            Console.WriteLine("Spróbuj opowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby rozpocząc grę ...");
            Console.ReadLine();
        }

        public void DisplayFailAndGameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("NIESTETY TO NIE JEST PRAWIDŁOWA ODPOWIEDŹ ...");
            Console.WriteLine("KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public void FinalScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("BRAWO !!!, UKOŃCZYŁEŚ/AŚ QUIZ !!!");
            Console.WriteLine("KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }


        public void GoodAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Brawo, to prawidłowa odpowiedź ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nacisnij ENTER, aby zobaczyć kolejne pytanie ...");
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
