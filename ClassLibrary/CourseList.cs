using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class CourseList
    {
        public List<Course> Courses { get; set; }
        public int Count { get; set; }

        public CourseList()
        {
            Courses = new List<Course>();
            Count = 0;
        }

        public void Add(Course course)
        {
            Courses.Add(course);
            Count++;
        }

        public void NoLongerThanThreeMonths
        {

        }
    }
}
