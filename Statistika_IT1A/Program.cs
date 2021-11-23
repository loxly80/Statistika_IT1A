using System;

namespace Statistika_IT1A
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(false);   //Zachycení stisknuté klávesy
                if(keyInfo.Key == ConsoleKey.Enter)
                {
                    //když uživatel zmáčkne Enter

                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {

                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
