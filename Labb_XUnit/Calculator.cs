using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_XUnit
{
    public class Calculator
    {
        private List<string> _calculationHistory;
        public Calculator()
        {
            _calculationHistory = new List<string>();
        }

        public decimal Addition(decimal x, decimal y)
        {
            return x + y;
        }

        public decimal Subtraction(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
                throw new DivideByZeroException("Du kan inte dela med 0");
            return x / y;
        }

        public decimal Multiplication(decimal x, decimal y)
        {
            return x * y;
        }

        public void SaveCalculation(string calculation, decimal result)
        {
            _calculationHistory.Add($"{calculation} = {result}");
        }
        public void PrintHistory()
        {
            if (_calculationHistory.Count == 0)
            {
                Console.WriteLine("Inga uträkningar har gjorts.");
            }
            else
            {
                foreach (var calc in _calculationHistory)
                {
                    Console.WriteLine(calc);
                }
            }
        }
        public void Run()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                string operation = GetOperationFromUser();
                decimal num1 = GetNumber("Ange det första talet:");
                decimal num2 = GetNumber("Ange det andra talet:");

                decimal result = PerformCalculation(operation, num1, num2, out string calculation);
                SaveCalculation(calculation, result);
                Console.WriteLine($"Result: {result}");

                keepGoing = AskToContinue();

                if (AskToSeeHistory())
                {
                    PrintHistory();
                }
            }
        }

       

        private bool AskToSeeHistory()
        {
            Console.WriteLine("Vill du se loggen över uträkningar som gjorts? (ja/nej)");
            string historyChoice = Console.ReadLine().Trim().ToLower();
            return historyChoice == "ja";
        }


        private bool AskToContinue()
        {
            Console.WriteLine("Vill du utföra en ny uträkning? (ja/nej)");
            string continueChoice = Console.ReadLine().Trim().ToLower();
            return continueChoice == "ja";
        }

        private decimal GetNumber(string prompt)
        {
            Console.WriteLine(prompt);
            return GetNumberFromUser();
        }

        private decimal GetNumberFromUser()
        {
            decimal number;
            while (!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ogiltigt val, vad god använd siffror");
            }
            return number;
        }

        private string GetOperationFromUser()
        {
            Console.WriteLine("Välj en operation: Addition, Subtraktion, Division, Multiplikation");
            return Console.ReadLine().Trim().ToLower();
        }



        private decimal PerformCalculation(string operation, decimal num1, decimal num2, out string calculation)
        {
            decimal result = 0;
            calculation = "";

            switch (operation)
            {
                case "addition":
                    result = Addition(num1, num2);
                    calculation = $"{num1} + {num2}";
                    break;
                case "subtraktion":
                    result = Subtraction(num1, num2);
                    calculation = $"{num1} - {num2}";
                    break;
                case "division":
                    try
                    {
                        result = Divide(num1, num2);
                        calculation = $"{num1} / {num2}";
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    break;
                case "multiplikation":
                    result = Multiplication(num1, num2);
                    calculation = $"{num1} * {num2}";
                    break;
                default:
                    Console.WriteLine("Ogiltig val, välj en av ovanstående.");
                    throw new InvalidOperationException("Invalid operation.");
            }

            return result;
        }
    }
}
