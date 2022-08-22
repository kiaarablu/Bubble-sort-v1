using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_V1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] b = { 40, 20, 10, 30 };
            Bubble a = new Bubble();
            a.SortArray(b);
            Console.ReadKey();
            
        }
    }
}
