using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task4
{
    public class GuessNumber
    {
        public int Number { get; set; } = new Random().Next(0, 10);
        public int Lives { get; set; } = 3;

        public void Game()
        {
            WriteLine("Guess number(0-10):");               //НЕ ТЕ НАПИСАВ ВЗАГАЛІ

            bool isGuessed = false;
            for (int i = 0; i < Lives; i++)
            {
                Write("Your answer: ");
                if (int.Parse(ReadLine() ?? "-1") == Number)
                {
                    isGuessed = true;
                    break;
                }
            }
            if (isGuessed) WriteLine("You win!");
            else WriteLine("You loose!");
        }
    }
}
