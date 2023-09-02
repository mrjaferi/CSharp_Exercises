using System;

namespace BMI_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckValidations(args);
            ExecuteCalculation(args);
        }

        static void ExecuteCalculation(string[] args)
        {
            var firstSwitch = args[1];
            var firstArg = args[2];

            var secondSwitch = args[3];
            var secondArg = args[4];

            double height, weight;

            switch (firstSwitch)
            {
                case "--height":
                    if (secondSwitch != "--weight")
                    {
                        ShowErrorMessage();
                        break;
                    }
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;
                case "--weight":
                    if (secondSwitch != "--height")
                    {
                        ShowErrorMessage();
                        break;
                    }
                    weight = Convert.ToDouble(firstArg);
                    height = Convert.ToDouble(secondArg);
                    CalculateBmi(height, weight);
                    break;
                default:
                    ShowErrorMessage();
                    break;
            }
        }

        static void CheckValidations(string[] args)
        {
            if (args.Length == 0 || args[0] != "bmi")
            {
                ShowErrorMessage();
                Environment.Exit(0);
            }
            else if (args[1] == "--helps")
            {
                ShowHelp();
                Environment.Exit(0);
            }
            else if (args[1] == "--version")
            {
                ShowCurrentVersion();
                Environment.Exit(0);
            }
        }

        static void CalculateBmi(double height, double weight)
        {
            Console.WriteLine("\nYour BMI Score is:");
            var bmi = Math.Round(weight / (height * height));
            var status = "";
            if (bmi <= 18.4)
            {
                status = "Underweight";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                status = "Normal";
            }
            else if (bmi > 25.0 && bmi < 39.9)
            {
                status = "Overweight";
            }
            else if (bmi >= 40)
            {
                status = "Obese";
            }
            Console.WriteLine(bmi);
            Console.WriteLine($"Your Status is: {status}");
        }

        static void ShowHelp()
        {
            Console.WriteLine("\nUse these switch to run program:");
            Console.WriteLine("--height\tYour height (centimeters)");
            Console.WriteLine("--weight\tYour weight (kilograms)");
            Console.WriteLine("--version\tShow current version");
            Console.WriteLine("--helps\t\tShow command list");
        }

        static void ShowErrorMessage()
        {
            Console.WriteLine("\nInvalid command :(");
            Console.WriteLine("Use --helps switch to show help");
        }

        static void ShowCurrentVersion()
        {
            Console.WriteLine("\nCurrent version is: 1.0");
        }
    }
}