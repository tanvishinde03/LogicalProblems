using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fibonacci Series \n 2. PerfectNum 3. PrimeNum \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Displayfibonacci();
                    break;

                case 2:
                    PerfectNum obj = new PerfectNum();
                    obj.checkperfectnumber();
                    break;
                case 3:
                    PrimeNum Obj = new PrimeNum();
                    Obj.Prime();
                    break;
                case 4:
                    ReverseNum obJ = new ReverseNum();
                    obJ.Display();
                    break;
        }
            Console.ReadLine();
        }
    }
    















        }
    

