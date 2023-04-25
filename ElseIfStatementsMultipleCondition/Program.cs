using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfStatementsMultipleCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = 3;
            if (guests >= 4)
            {
                Console.WriteLine("Catan");
            }
            else
            if (guests == 1 && guests == 3)
            {
                Console.WriteLine("Innovation");
            }
            else
            {
                Console.WriteLine("Solitaire");
            }
        }
    }
}
