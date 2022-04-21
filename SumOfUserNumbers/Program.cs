using System;

namespace SumOfUserNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Сумма трех чисел
            //приложение предлагает пользователю ввести три числа и выводит на экран их сумму
            //исправленный до рабочего состояния код дает до 5 пунктов 


            Console.WriteLine("enter 3 numbers:");

            int userNumber = Convert.ToInt32(Console.ReadLine());
            int sum = Convert.ToInt32(Console.ReadLine());
            int num = Convert.ToInt32(Console.ReadLine());
            


            for (int i = 0; i < 3; i++);
            {
                
                
                Console.WriteLine($"{sum} + {userNumber} + {num}");
               
            }
            
         Console.WriteLine($"Total: {sum + userNumber + num }");
          
          
}



        }

        
        
    }       