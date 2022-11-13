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
            Console.WriteLine();
            Console.WriteLine("Witamy w Quizie gr 4");
            Console.WriteLine("Spróbuj opowiedzieć na 7 pytań");
            Console.WriteLine("POWODZENIA !!!");
            Console.WriteLine();
            Console.WriteLine("Naciśnij ENTER aby rozpocząc grę ...");
            Console.ReadLine();
        }
    }
}
