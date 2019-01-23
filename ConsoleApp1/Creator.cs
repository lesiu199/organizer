using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    public class Creator
    {
        private List<Meeting> _meeting = new List<Meeting>();
        private List<Exercises> _exersice = new List<Exercises>();
        private List<Object> _all = new List<Object>();

        public bool AddMeeting(string name, string desc, DateTime date)
        {
            _meeting.Add(new Meeting(name, desc, date));
            _all.Add(_meeting.Last());
            return true;
        }
        public bool AddExercise(string name, string desc, DateTime date, int duration)
        {

            _exersice.Add(new Exercises(name, desc, date, duration));
            _all.Add(_exersice.Last());
            return true;
        }
        public void ShowAll()
        {
            Console.WriteLine("-------------");
            foreach (IEvent i in _all)
            {
                
                Console.WriteLine($"Obiekt: {i.Show()}");
                Console.WriteLine("--");
            }
            Console.WriteLine("-------------");
        }
        

    }
}
