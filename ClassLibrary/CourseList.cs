using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class CourseList
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

        public void NoLongerThanThreeMonths()
        {
            Console.WriteLine("Платные курсов длительностью не более 3 месяцев:");
            var selectedCourses = from c in Courses where (c.Duration < 3 && c.IsPaid) select c;
            foreach (var c in selectedCourses)
                Console.WriteLine(c);
            Console.WriteLine("Бесплатные курсов длительностью не более 3 месяцев:");
            selectedCourses = from c in Courses where (c.Duration < 3 && !c.IsPaid) select c;
            foreach (var c in selectedCourses)
                Console.WriteLine(c);
        }

        public void TenMostListenedSortedByPrice()
        {
            var selectedCourses = (from c in Courses where (c.IsPaid == true) orderby c.Listeners descending select c).Take(10).OrderBy(c => c.Price);
            using (var SW = new StreamWriter("output.txt"))
            {
                foreach (var c in selectedCourses)
                    Console.WriteLine(c);
            }
        }

        public void FreeCoursesByLecturePerWeek()
        {
            var selectedCourses = (from c in Courses where (c.IsPaid == false) orderby c.LecturesPerWeek select c);
            Console.WriteLine("Бесплатные курсы отсортированные по среднему количеству лекций в неделю:");
            foreach (var c in selectedCourses)
                Console.WriteLine(c + " - " + c.LecturesPerWeek);
        }
    }
}