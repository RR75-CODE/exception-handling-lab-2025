using System;
using System.Diagnostics;

namespace Lab5_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred:" + ex.Message);
            }
            finally
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Log message example", EventLogEntryType.Information, 101, 1);
                }

                Console.WriteLine("Event written to Application Log.");
            }
        }
    }
}

