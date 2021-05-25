
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AssignmentLibrary;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConvertor currencyConvertor = new CurrencyConvertor();
            int ChoiceConversionType;
            Console.WriteLine("Choose any method to continue : \n 1-Conversion By using default Conversion Rate  \n 2- Conversion By using own Conversion Rate");
            ChoiceConversionType = int.Parse(Console.ReadLine());
            switch (ChoiceConversionType)
            {
                case 1:
                    currencyConvertor.DefaultConversion();
                    break;

                case 2:
                    currencyConvertor.UserConversion();
                    break;
            }
            
           

        }
    }
}