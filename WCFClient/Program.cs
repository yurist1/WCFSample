using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.Service1Client calcul = new CalculatorService.Service1Client();
            Console.WriteLine(calcul.GetCalculate(1, 4, 0));
            Console.Read();
        }
    }
}
