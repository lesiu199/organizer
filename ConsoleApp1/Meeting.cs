using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    public class Meeting : BaseEvent, IEvent
    {
        public Meeting(string name, string desc, DateTime date) : base(name, desc, date)
        {

        }

        public string Show()
        {
            return "Dane: \nNazwa: " + Name + " \n Data: " + Data + "\nOpis: " + Desc;
        }

    }
}
