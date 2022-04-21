using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Игра в кости
            //Компьюьер (cpu) и пользователь (user) играют в кости 
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто выбросил больший результат, то и победил в игре
            //бросок выполняется один раз
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userThrow - бросок пользователем; cpuScore - бросок компьютера;


            Console.WriteLine("User vs Computer");
            Console.WriteLine("Start Dice Game!Press Enter! ");
            Console.ReadKey();
            Random rnd = new Random();

            int userThrow;
            int cpuThrow;
            int userScore = 0;
            int cpuScore = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Computer roll the dice!");
                cpuThrow = rnd.Next(1, 7);
                Console.WriteLine("Computer score " + cpuThrow);

                Console.WriteLine(" ... ");

                userThrow = rnd.Next(1, 7);
               
                Console.WriteLine("You turn!Press Enter!");
                Console.ReadKey();
                Console.WriteLine("You roll the dice!");
                Console.WriteLine("Your score " + userThrow);
                Console.WriteLine();

                if (userThrow > cpuThrow)
                {
                    userScore++;
                    Console.WriteLine("You Win!");
                }
                else if (userThrow < cpuThrow)
                {
                    cpuScore++;
                    Console.WriteLine("Computer Win!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("Try again!");
            }
        }
    }
}
