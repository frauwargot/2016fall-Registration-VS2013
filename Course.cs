using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_containing_list_of_objects
{
    public class Course
    {
        //fields
        private string _courseName;
        private string _courseNumber;
        private List<double> _listOfGrades;

        //constructor
        public Course(string courseName, string courseNumber)
        {
            _courseName = courseName;
            _courseNumber = courseNumber;
            _listOfGrades = new List<double>();
        }

        //properties
        public string CourseName { get { return _courseName; } }
        public string CourseNumber { get { return _courseNumber; } }

        public double[] ListOfGrades
        { get { return _listOfGrades.ToArray(); } }

        public double GetAverageGrade(Course c)
        {
            //double average = 0;
            //double total = 0;
           
            //foreach (double g in c._listOfGrades)
            //{
            //    total += g;          
            //}
            //average = total / _listOfGrades.Count;
            //return average;
            //======================using Average() method defined
            //in the List<> class
            return _listOfGrades.Average();

            
        }//End GetAverage

        public double GetLowestGrade(Course c)
        {
            double lowest = _listOfGrades[0];

            //foreach (double l in c._listOfGrades)
            //{
            //    if (l < lowest)
            //    {
            //        lowest = l;
            //    }
            //}
            //return lowest;

            return _listOfGrades.Min();
        }//end GetLowestGrade

        public double GetHighestGrade(Course c)
        {
            //double highest = _listOfGrades[0];
            //foreach (double h in c._listOfGrades)
            //{
            //    if (h > highest)
            //    {
            //        highest = h;
            //    }
            //}
            //return highest;
            return _listOfGrades.Max();
        }//end GetHighestGrade

        public void AddGrade(double g)
        {
            _listOfGrades.Add(g);
        }//end AddGrade

        public void RemoveGrade(int index_grade)
        {
            _listOfGrades.RemoveAt(index_grade);
        }
        public void ChangeLastGrade(double g)
        {
            _listOfGrades.RemoveAt(_listOfGrades.Count - 1);
            _listOfGrades.Add(g);
        }//end ChangeLastGrade

    }
}
