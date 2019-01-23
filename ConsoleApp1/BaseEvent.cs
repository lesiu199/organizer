using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOrganizer
{
    public abstract class BaseEvent
    {
        private DateTime data;
        private string name;
        private string desc;

        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Data { get; set; }

        protected BaseEvent(string name, string desc, DateTime date)
        {
            this.Name = name;
            this.Desc = desc;
            this.Data = date;
        }
    }
}
