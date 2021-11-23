using BrownField.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownField
{
    public class TimeSheetProcessor
    {
        public double GetHoursWorkForCompany(List<TimeSheetEntry> timeSheetEntries, string companyName)
        {
            double totalHoursWorked = 0;
            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(companyName))
                {
                    totalHoursWorked += timeSheetEntries[i].HoursWorked;
                }
            }

            return totalHoursWorked;
        }

        public decimal CalcualateForWorkHours(List<TimeSheetEntry> timeSheets, Employee employee)
        {
            decimal paymentForWorkedHours = 0;
            double totalWorkedHours = 0;

            for (int i = 0; i < timeSheets.Count; i++)
            {
                totalWorkedHours += timeSheets[i].HoursWorked;
            }
            if (totalWorkedHours > 40)
            {
                paymentForWorkedHours = (decimal)(totalWorkedHours - 40) * (employee.HourlyRate*1.5M) + (40 * employee.HourlyRate);
            }
            else
            {
                paymentForWorkedHours = (decimal)totalWorkedHours * employee.HourlyRate;
            }

            return paymentForWorkedHours;
        }
    }
}
