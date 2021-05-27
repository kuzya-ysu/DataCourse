using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public bool IsPaid { get; set; }
        public int Listeners { get; set; }
        public int Reviews { get; set; }
        public int Lectures { get; set; }
        public string Difficulty { get; set; }
        public double Duration { get; set; }

        public override string ToString()
        {
            string course = ID + " " + Name;
            return course;
        }

    }
}
