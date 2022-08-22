using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework1_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int enterNumber = random.Next(0, 100000);
            int powNumber = 2;
            int indexNumber = 2;
            int maxNumber;
            int powCount = 0;

            for(maxNumber=indexNumber; maxNumber<enterNumber; maxNumber*=powNumber)
            {
                powCount++;
            }

            Console.WriteLine("Для числа " + enterNumber + " максимальное число равно " + maxNumber + ". Это " + indexNumber + " в " + powCount + " степени.");         
        }
    }
}