using System;
using System.IO;

namespace AssignmentLibrary
{
    public class CurrencyConvertor
    {
        public void UserConversion()
        {

            int choice;

            Console.WriteLine("Enter your Choice :\n 1- Dollar to Rupee \n 2 - Euro to Rupee \n 3 - Malaysian  to Rupee  \n 4 - Yuan to Rupee \n 5 - Rubel to Rupee");

            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Double dollar, rupee, dollarValue;
                    Console.WriteLine("Enter the Dollar Amount :");
                    dollar = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Dollar Value :");
                    dollarValue = double.Parse(Console.ReadLine());
                    rupee = dollar * dollarValue;
                    Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);
                    break;
                case 2:
                    Double Euro, rupe, euroValue;
                    Console.WriteLine("Enter the Euro Amount :");
                    Euro = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Euro Value :");
                    euroValue = double.Parse(Console.ReadLine());
                    rupe = Euro * euroValue;
                    Console.WriteLine("{0} Euro Equals {1} Rupees", Euro, rupe);
                    break;
                case 3:
                    Double ringit, rup, ringitValue;
                    Console.WriteLine("Enter the Ringgit Amount :");
                    ringit = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Ringgit Value :");
                    ringitValue = double.Parse(Console.ReadLine());
                    rup = ringit * ringitValue;
                    Console.WriteLine("{0} Malaysian Ringgit Equals {1} Rupees",
                                                      ringit, rup);
                    break;
                case 4:
                    Double yuan, rupp, yuanValue;
                    Console.WriteLine("Enter the Yuan Amount :");
                    yuan = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Yuan Value :");
                    yuanValue = double.Parse(Console.ReadLine());
                    rupp = yuan * yuanValue;
                    Console.WriteLine("{0} China yuan Equals {1} Rupees",
                                                  yuan, rupp);
                    break;
                case 5:
                    Double ruble, ruppp, rubleValue;
                    Console.WriteLine("Enter the ruble Amount :");
                    ruble = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Ringgit Value :");
                    rubleValue = double.Parse(Console.ReadLine());


                    ruppp = ruble * rubleValue;
                    Console.WriteLine("{0} Russia ruble Equals {1} Rupees",
                                                  ruble, ruppp);
                    break;

            }
            Console.ReadLine();
        }


        public void DefaultConversion()
        {
            string file = @"C:\Users\adityas\Desktop\Conversion.txt";
            if (File.Exists(file))
            {
                // Store each line in array of strings
                string[] lines = File.ReadAllLines(file);
                Console.WriteLine("Conversion Rates  ");

                foreach (string ln in lines)
                    Console.WriteLine(ln);


                int choice;

                Console.WriteLine("Enter your Choice :\n 1- Dollar to Rupee \n 2 - Euro to Rupee \n 3 - Malaysian  to Rupee  \n 4 - Yuan to Rupee \n 5 - Rubel to Rupee");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Double dollar, rupee;
                        Console.WriteLine("Enter the Dollar Amount :");
                        dollar = Double.Parse(Console.ReadLine());
                        rupee = dollar * Convert.ToDouble(lines[1]);
                        Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);
                        break;
                    case 2:
                        Double Euro, rupe;
                        Console.WriteLine("Enter the Euro Amount :");
                        Euro = Double.Parse(Console.ReadLine());
                        rupe = Euro * Convert.ToDouble(lines[2]);
                        Console.WriteLine("{0} Euro Equals {1} Rupees", Euro, rupe);
                        break;
                    case 3:
                        Double ringit, rup;
                        Console.WriteLine("Enter the Ringgit Amount :");
                        ringit = Double.Parse(Console.ReadLine());
                        rup = ringit * Convert.ToDouble(lines[3]);
                        Console.WriteLine("{0} Malaysian Ringgit Equals {1} Rupees",
                                          ringit, rup);
                        break;
                    case 4:
                        Double yuan, rupp;
                        Console.WriteLine("Enter the Yuan Amount :");
                        yuan = Double.Parse(Console.ReadLine());
                        rupp = yuan * Convert.ToDouble(lines[4]);
                        Console.WriteLine("{0} China yuan Equals {1} Rupees",
                                          yuan, rupp);
                        break;
                    case 5:
                        Double ruble, ruppp;
                        Console.WriteLine("Enter the ruble Amount :");
                        ruble = Double.Parse(Console.ReadLine());
                        ruppp = ruble * Convert.ToDouble(lines[5]);
                        Console.WriteLine("{0} Russia ruble Equals {1} Rupees",
                                          ruble, ruppp);
                        break;

                }
                Console.ReadLine();
            }


        }


    }
}
