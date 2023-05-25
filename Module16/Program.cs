using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Additional(1, 2);
            calculator.Subtraction(10, 4);
            calculator.Miltiplication(5, 5);
            calculator.Division(20, 4);
        }
    }
}
