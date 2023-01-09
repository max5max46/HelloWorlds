using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorlds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count != -1)
            {
                count++;
                Console.WriteLine("Hello my guy " + count);
            }
        }
    }
}
