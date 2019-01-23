using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    public class Exercises : BaseEvent, IEvent
    {
       public Exercises(string name, string desc, DateTime date, int duration) : base(name, desc, date)
        {
            this.Duration = duration;
        }

        private int _duration;

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }

        public string Show()
        {
            return "Dane: \nNazwa: "+ Name + " \n Data: "+ Data +"\nOpis: "+ Desc +" -> "+ Duration +" min";
        }

    }
}
