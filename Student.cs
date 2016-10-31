using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_containing_list_of_objects
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private List<Course> _courseList;

        //constructor
        public Student(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
            _courseList = new List<Course>();

        }

        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }

        public Course[] CourseList
        { get { return _courseList.ToArray(); } }

        public void AddCourse(Course c)
        {
            _courseList.Add(c);
        }

        public void RemoveCourse(Course c)
        {
            _courseList.Remove(c);
        }
    }
}
