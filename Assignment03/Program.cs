using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bubble sort
            Random rd = new Random();
            int[] numbers = new int[100];
            int loop = numbers.Length - 1;
            int lenght = numbers.Length;
            int temp;
            var startTime = DateTime.Now;
            for(int i = 0; i < lenght; i++)
            {
                numbers[i] = rd.Next(0, 100);
            }
            Console.WriteLine("\nUnsorted Array: ");
            foreach(var i in numbers)
            {
                Console.Write($"{i} ");
            }
            for (int i=0; i< loop; i++)
            {
                for(int j=0; j < loop; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array: ");
            foreach (var i in numbers)
            {
                Console.Write($"{i} ");
            }
            var time = DateTime.Now.Subtract(startTime);
            Console.WriteLine($"\r\nExecution time: {time.Milliseconds}(ms)");
            Console.ReadKey();
        }
    }
}
