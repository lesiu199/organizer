using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    public class CalendarField
    {
        public CalendarField()
        {
            InitializeCal();    
        }

        private void InitializeCal()
        {


            /*List<DateTime> lastMonth = new List<DateTime>();
            List<DateTime> curMonth = new List<DateTime>();
            List<DateTime> nextMonth = new List<DateTime>();*/
            DateTime cur = DateTime.Now.AddMonths(-1);
            ShowMonth(cur);
            cur = DateTime.Now;
            ShowMonth(cur);
            cur = DateTime.Now.AddMonths(1);
            ShowMonth(cur);
           // Console.WriteLine(DateTime.DaysInMonth(cur.Year, cur.AddMonths(3).Month));

            //string lastMonth = DateTime.Today.AddMonths(-1).ToString("MMMM");
            //string nextMonth = DateTime.Today.AddMonths(1).ToString("MMMM");
            //Console.WriteLine($"Cur Month: {curMonth}\n Last Month:{lastMonth}\n Next Month: {nextMonth}");


        }

        private void ShowMonth(DateTime d)
        {
            Console.WriteLine(d.ToString("MMMM") + "\n");
            //Days
            for (int i = 1; i <= DateTime.DaysInMonth(d.Year, d.Month); i++)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
