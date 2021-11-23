using BrownField;
using BrownField.Models;
using System;
using System.Collections.Generic;

namespace RefactoringToGoodCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee { FirstName = "Türkay", HourlyRate = 20 };
            
            double totalWrokedHours;
            List<TimeSheetEntry> timeSheets = LoadTimeSheets();
            TimeSheetProcessor timeSheetProcessor = new TimeSheetProcessor();
            totalWrokedHours = timeSheetProcessor.GetHoursWorkForCompany(timeSheets, "acme");           
            BillInfo("Acme", 150, totalWrokedHours);
            totalWrokedHours = timeSheetProcessor.GetHoursWorkForCompany(timeSheets, "abc");
            BillInfo("ABC", 120, totalWrokedHours);

            var payment = timeSheetProcessor.CalcualateForWorkHours(timeSheets,employee);

            Console.WriteLine("You will get paid $" + payment + " for your time.");

            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }

        static void BillInfo(string companyName, decimal hourlyRate, double totalWorkedHours)
        {
            Console.WriteLine($"Simulating Sending email to {companyName} ");
            Console.WriteLine("Your bill is $" + (decimal)totalWorkedHours * hourlyRate + " for the hours worked.");
        }

        private static List<TimeSheetEntry> LoadTimeSheets()
        {
            List<TimeSheetEntry> loadedTimeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDone = Console.ReadLine();
                Console.Write("How long did you do it for: ");
                string rawTimeWorked = Console.ReadLine();
                double timeWorked = getDoubleFromValue(ref rawTimeWorked);
                TimeSheetEntry timeSheetEntry = getTimeSheet(workDone, timeWorked);
                loadedTimeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            return loadedTimeSheetEntries;
        }

        private static TimeSheetEntry getTimeSheet(string workDone, double timeWorked)
        {
            TimeSheetEntry timeSheetEntry = new TimeSheetEntry();
            timeSheetEntry.HoursWorked = timeWorked;
            timeSheetEntry.WorkDone = workDone;
            return timeSheetEntry;
        }

        private static double getDoubleFromValue(ref string rawTimeWorked)
        {
            double timeWorked = 0;
            while (double.TryParse(rawTimeWorked, out timeWorked) == false)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number given");
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
            }

            return timeWorked;
        }
    }


}

