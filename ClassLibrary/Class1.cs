using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public bool IsPaid { get; set; }
        public int Price { get; set; }
        public int Listeners { get; set; }
        public int Reviews { get; set; }
        public int Lectures { get; set; }
        public string Difficulty { get; set; }
        public double Duration { get; set; }
        internal double LecturesPerWeek { get; set; }

        public Course(int id, string name, string url, bool ispaid, int price, int listeners, int reviews, int lectures, string difficulty, double duration)
        {
            ID = id;
            Name = name;
            URL = url;
            IsPaid = ispaid;
            Price = price;
            Listeners = listeners;
            Reviews = reviews;
            Lectures = lectures;
            Difficulty = difficulty;
            Duration = duration;
            if (IsPaid == false)
                LecturesPerWeek = Lectures / (Duration / 4.0);
        }

        public override string ToString()
        {
            string course = ID + " " + Name;
            return course;
        }
    }
}