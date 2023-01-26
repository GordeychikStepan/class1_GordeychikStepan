using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SquareCycle
    {   
        public void Repeat()
        {
            int square;
            for (int i = 1; i < 10; i++)
            {
                square = (int)Math.Pow(i, 2);
                Console.WriteLine(i);
                StopCycle pr = new StopCycle();
                pr.Print(square);
            }
        }
    }
}
