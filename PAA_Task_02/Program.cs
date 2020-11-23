using System;

namespace PAA_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            while("exit" != exit)
            {
                Console.WriteLine("Чтобы выйти из программы введите \"exit\" ");
                exit = Console.ReadLine();
            }
        }
    }
}
