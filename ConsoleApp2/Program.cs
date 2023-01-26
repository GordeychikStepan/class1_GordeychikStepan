using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                // 1 и 2 задание
                /*Tel tel = new Tel();
                do
                {
                    Console.Write("День разговора (1 - 7): ");
                    tel.dayTalked = Convert.ToInt32(Console.ReadLine());
                    if (tel.dayTalked > 7 || tel.dayTalked < 1) Console.WriteLine("Повторите ввод дня...");
                } while (tel.dayTalked > 7 || tel.dayTalked < 1);
                Console.Write("Время разговора: ");
                tel.talkingTime = Convert.ToDouble(Console.ReadLine());
                Console.Write("Стоимость: ");
                tel.talkingCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Итоговая стоимость: {tel.CalculateSum()}");*/

                // 3 задание
                SquareCycle cycle = new SquareCycle();
                cycle.Repeat();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            

            Console.ReadKey();
        }
    }
}
