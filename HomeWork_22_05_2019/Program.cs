using System;

namespace HomeWork_22_05_2019
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Введите в одной строке делимое и делитель, затем нажмите <Enter>");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());



            if (b == 0) 
            {
                Console.WriteLine("Вы ошиблись. Делитель не должен быть равен нулю.");
            }
            else 
            {
                Console.WriteLine("Частное из введенных чисел составляет = " + (a / b)); 
            }

        }
    }
}
