using System;

namespace DiceGameThreeThrowsForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            //Игра в кости - три броска
            //Компьюьер (cpu) и пользователь (user) играют в кости
            //Компьютер "бросает кубик" и пользователь "бросает кубик" (за пользователя тоже играет класс рандом)
            //Всего выполняется 3 броска
            //Значения, которые могут выпасть находятся в диапазоне от 1-6 (включительно)
            //Кто за три броска набрал большее количетво очков, тот и выиграл
            //исправленный до рабочего состояния код дает до 10 пунктов 

            //комментарии к переменным: userScore - очки, набранные пользователем; cpuScore - очки, набранные компьютером


            Console.WriteLine("Welcome to  Dice Game!");
           
            Console.WriteLine("User vs Computer");
             Console.WriteLine("Everyone has a 3 times for s roll the dice.");
             Console.WriteLine("Who scored more points in 3 throws, win!");
            Console.WriteLine("Press Enter to start!");
            Console.ReadKey();
            

            Random rnd =  new Random();

            int userThrow;
            int cpuThrow;

            int userScore = 0;
            int cpuScore = 0;
            int count = 1;

            for(int i = 0; i < 3; i++)
            {
                userThrow= rnd.Next(1, 7);
                cpuThrow = rnd.Next(1, 7);

                Console.WriteLine();
                Console.WriteLine($"Roll dice {count++} -> user: {userThrow}, computer: {cpuThrow}");

                if (userThrow < cpuThrow)
                {
                    cpuScore++;
                } 
                else if(userThrow > cpuThrow)
                {
                    userScore++;
                }
                else
                {
                    continue;   //этот блок просто сообщит коду, продолжать работу, если пользователь и компьюьер
                                //выбросят одинаковое значение, эта часть не нуждается в исправлении
                }
            }
                 Console.WriteLine();
                 Console.WriteLine($"User scored  = { userScore}");
                 Console.WriteLine($"Computer scored = {cpuScore}");
            Console.WriteLine();

            if (cpuScore > userScore)
            {
                Console.WriteLine("Computer Win!");//эта строка не подлежит правке
            }
            else if (userScore > cpuScore) 
            {
                Console.WriteLine("User Win!"); //эта строка не подлежит правке
             } 
            else  
            {
                Console.WriteLine("Draw!");
            }
        }
    }
}
