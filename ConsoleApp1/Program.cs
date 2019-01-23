using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator c = new Creator();
            CalendarField cal = new CalendarField();
            c.AddMeeting("spotkanie", "opis", DateTime.Now);
            c.AddMeeting("dddd", "Teamdd", DateTime.Today);
            c.AddExercise("Runa", "Pobidegane", DateTime.Now, 44);

            c.ShowAll();
            
        }
    }
}
