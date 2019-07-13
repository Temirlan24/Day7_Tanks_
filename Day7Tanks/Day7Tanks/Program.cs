using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MyClassLib.WorldOfTanks;

namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Thread.Sleep(20);
            const string firstTank = "T-34";
            const string secondTank = "Pantera";
            int ammunition, armor, mobility;
            const int countOfTanks = 5;
            Tank[] t34 = new Tank[countOfTanks];
            Tank[] pantera = new Tank[countOfTanks];
            for (int i = 0; i < countOfTanks; i++)
            {
                Console.WriteLine($"{i + 1} схватка: ");
                ammunition = random.Next(0, 100);
                armor = random.Next(0, 100);
                mobility = random.Next(0, 100);
                t34[i] = new Tank(firstTank, ammunition, armor, mobility);
                t34[i].ShowTanks();
                Console.WriteLine();
                ammunition = random.Next(0, 100);
                armor = random.Next(0, 100);
                mobility = random.Next(0, 100);
                pantera[i] = new Tank(secondTank, ammunition, armor, mobility);
                pantera[i].ShowTanks();
                Console.WriteLine();
            }
            Tank[] win = new Tank[5];

            for (int i = 0; i < 5; i++)
            {
                win[i] = new Tank();
                win[i] = t34[i] * pantera[i];

                Console.WriteLine();
                Console.WriteLine($"В {i + 1} схватке победил");
                win[i].ShowTanks();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
