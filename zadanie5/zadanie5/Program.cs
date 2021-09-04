using System;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Z;
            int P = 0; int L = 0;
            string word, EX;
            bool Выход = false;
            Console.WriteLine("Добро пожаловать в игру Камень - Ножницы - Бумага!");

            while (!Выход)
            {
                Console.WriteLine("Что у вас ? (ножницы / бумага / камень) ? Для выхода наберите(выход).");

                word = Console.ReadLine(); 
                word = word.ToLower().Trim();    
                if (word == "выход" || P == 20 || L == 20) goto FINISH;

                Random random = new Random();
                Z = random.Next(3);
                switch (Z)
                {
                    case 0: Console.WriteLine("Компьютер выбрал — камень!"); break;
                    case 1: Console.WriteLine("Компьютер выбрал — ножницы!"); break;
                    default: Console.WriteLine("Компьютер выбрал — бумага!"); break;
                }
                if (word == "камень")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 0) {  Console.WriteLine("Ничья"); }
                    else if (Z == 1) { Console.WriteLine("Вы победили"); P++;  }
                    else {  Console.WriteLine("Вы проиграли"); L++;   }
                }
else if (word == "ножницы")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 1) {  Console.WriteLine("Ничья"); }
                    else if (Z == 2) { Console.WriteLine("Вы победили"); P++;   }
                    else {  Console.WriteLine("Вы проиграли"); L++;   }
                }
else if (word == "бумага")
{
                    Console.WriteLine("Ваш выбор — " +word);
                    if (Z == 2) {  Console.WriteLine("Ничья"); }
                    else if (Z == 0) {  Console.WriteLine("Вы победили"); P++;   }
                    else { ; Console.WriteLine("Вы проиграли"); L++;   }
                }
else
                {
                    Console.WriteLine("Ваш выбор — неизвестен программе.Хотите выйти(да / нет) ?");
                    EX = Console.ReadLine();
                    EX = EX.ToLower().Trim();
                    if (EX == "да") Выход = true;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }

        FINISH:
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Очки игрока " +P+ " ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Очки бота(димки) " +L+ " ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Осуществляется выход, нажмите любую клавишу. . .");
            Console.ReadKey();


            

        }
    }
}
