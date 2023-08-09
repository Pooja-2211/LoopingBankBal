using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingBankBal
{
    class Program
    {
        static void Main(string[] args)
        {
            double bankBal = 1000;
            const double INT_RATE = 0.04;
            string inputString;
            char response;
            Write("Do you want to see your balance? Y or N");
            inputString = ReadLine();
            response = Convert.ToChar(inputString);
            while(response == 'Y')
            {
                WriteLine("Bank balance is {0}", bankBal.ToString("C"));
                bankBal = bankBal + bankBal * INT_RATE;
                Write("Do you want to see next year's balance? Y or N...");
                inputString = ReadLine();
                response = Convert.ToChar(inputString);
            }
            WriteLine("Have a nice day!");
        }
    }
}
