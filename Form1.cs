using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_containing_list_of_objects
{
    public partial class Form1 : Form
    {
        List<Student> studentsList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pre-load 5 students, each student with 1 to 3 courses
            //and each course 2 to 5 grades
            //==============================student1
            Student student1 = new Student("John", "Smith");
            Course course1 = new Course("Intro to programming", "CSI-152");            
            //add few grades to course1
            course1.AddGrade(66);
            course1.AddGrade(55);
            course1.AddGrade(67);
            //add course1 to student1
            student1.AddCourse(course1);
            //create another course to add to this student
            Course course2 = new Course("Database", "CSI-159");
            course2.AddGrade(66);
            course2.AddGrade(56);
            course2.AddGrade(44);
            course2.AddGrade(37);
            //add course2 to student1
            student1.AddCourse(course2);
            //add student1 to the list of students
            studentsList.Add(student1);
            //==============================student2
            Student student2 = new Student("Polina", "Vargot");
            Course course3 = new Course("Object or. pogramming", "CSI-245");
            //add few grades to course3
            course3.AddGrade(95);
            course3.AddGrade(95);
            course3.AddGrade(100);
            //add course1 to student2
            student2.AddCourse(course3);
            //create another course to add to this student
            Course course4 = new Course("Advansed Database", "CSI-255");
            course4.AddGrade(98);
            course4.AddGrade(91);
            course4.AddGrade(98);
            course4.AddGrade(100);
            //add course4 to student2
            student2.AddCourse(course4);
            //add student2 to the list of students
            studentsList.Add(student2);
            //=============================student3
            Student student3 = new Student("Alex", "Vargot");
            Course course5 = new Course("Intro to programming", "CSI-152");
            //add few grades to course5
            course5.AddGrade(100);
            course5.AddGrade(95);
            course5.AddGrade(82);
            //add course1 to student3
            student3.AddCourse(course5);
            //create another course to add to this student
            Course course6 = new Course("Database", "CSI-159");
            course6.AddGrade(89);
            course6.AddGrade(99);
            course6.AddGrade(93);
            course6.AddGrade(91);
            //add course6 to student3
            student3.AddCourse(course6);
            //add student3 to the list of students
            studentsList.Add(student3);
            //==========================student4
            Student student4 = new Student("Fedor", "Sevastianov");
            Course course7 = new Course("Mathimatics for Business and Industry", "MATH-185");
            //add few grades to course7
            course7.AddGrade(100);
            course7.AddGrade(95);
            course7.AddGrade(82);
            //add course1 to student4
            student4.AddCourse(course7);
            //create another course to add to this student
            Course course8 = new Course("Advansed Database", "CSI-255");
            course8.AddGrade(60);
            course8.AddGrade(99);
            course8.AddGrade(83);
            course8.AddGrade(91);
            //add course2 to student4
            student4.AddCourse(course8);
            //add student4 to the list of students
            studentsList.Add(student4);

            DisplayStudents(studentsList);

        }
        private void DisplayStudents(List<Student> stulist)
        {
            studentsListview.Items.Clear();
            foreach (Student stu in stulist)
            {
                ListViewItem lsvitem = new ListViewItem(stu.LastName);
                lsvitem.SubItems.Add(stu.FirstName);
                //add the row to the listview
                studentsListview.Items.Add(lsvitem);
            }
        }

        private void studentsListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradesListbox.Items.Clear();
            //for single selection, pick the first selected index
            //that means the selected index at 0
            if (studentsListview.SelectedIndices.Count > 0)
            { 
            int sindex = studentsListview.SelectedIndices[0];
            //Get the Student object at sindex
            Student student = studentsList[sindex];
            //get its courses list
            Course[] coursesList = student.CourseList;
                //display the courselist
                DisplayCourses(coursesList);
            }
        }
        private void DisplayCourses(Course[] courses)
        {
            coursesListview.Items.Clear();
            foreach (Course course in courses)
            {
                ListViewItem lsvitem = new ListViewItem(course.CourseNumber);
                lsvitem.SubItems.Add(course.CourseName);
                coursesListview.Items.Add(lsvitem);
            }
        }

        private void coursesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradesListbox.Items.Clear();
            if (coursesListview.SelectedIndices.Count > 0)
            {
                int sindex = studentsListview.SelectedIndices[0];
                int cindex = coursesListview.SelectedIndices[0];
                //Get the Student object at sindex               
                for (int j = 0; j < studentsList[sindex].CourseList[cindex].ListOfGrades.Length; j++)
                {
                    gradesListbox.Items.Add(studentsList[sindex].CourseList[cindex].ListOfGrades[j]);
                }                
            }
            //int indices = listView1.FocusedItem.Index;
            //listBox1.Items.Clear();
            //for (int j = 0; j < studentList[indices].CourseList.Length; j++)
            //{
            //    listBox1.Items.Add(studentList[indices].CourseList[j]);
            //}
        }

        private void btnAddCourseToSelectedStudent_Click(object sender, EventArgs e)
        {
            if (studentsListview.SelectedIndices.Count > 0)
            {
                int sindex = studentsListview.SelectedIndices[0]; 
                //get its courses list
                string NewCourseID = txtCourseID.Text.Trim();
                string NewCourseName = txtCourseName.Text.Trim();
                //student.AddCourse(NewCourseID, NewCourseName);
                ////display the courselist
                //DisplayCourses(coursesList);
                Course NewCourse = new Course(NewCourseID, NewCourseName);  
                //add course to student
                studentsList[sindex].AddCourse(NewCourse);               
                DisplayCourses(studentsList[sindex].CourseList);
            }
        }

        private void btnRemoveSelectedCourse_Click(object sender, EventArgs e)
        {
            int sindex = studentsListview.SelectedIndices[0];
            int cindex = coursesListview.SelectedIndices[0];
            //Get the Student object at sindex
            studentsList[sindex].RemoveCourse(studentsList[sindex].CourseList[cindex]);
            MessageBox.Show("Course has been removed!");
            DisplayCourses(studentsList[sindex].CourseList);
            gradesListbox.Items.Clear();
        }

        private void btnAddNewGrade_Click(object sender, EventArgs e)
        {
            try
            {                
                if (coursesListview.SelectedIndices.Count > 0)
                {
                    int sindex = studentsListview.SelectedIndices[0];
                    int cindex = coursesListview.SelectedIndices[0];
                    double NewGrade = double.Parse(txtNewGrade.Text.Trim());
                    if ((NewGrade < 0)||(NewGrade > 100))
                        MessageBox.Show("Invalid grade!");
                    else
                    {
                        gradesListbox.Items.Clear();
                        studentsList[sindex].CourseList[cindex].AddGrade(NewGrade);
                        MessageBox.Show("Grade has been added!");
                        //int gindex = gradesListbox.SelectedIndex;
                        //studentsList[sindex].CourseList[cindex].ListOfGrades[gindex];
                        for (int j = 0; j < studentsList[sindex].CourseList[cindex].ListOfGrades.Length; j++)
                        {
                            gradesListbox.Items.Add(studentsList[sindex].CourseList[cindex].ListOfGrades[j]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Course!");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnRemoveSelectedGrade_Click(object sender, EventArgs e)
        {
            if (coursesListview.SelectedIndices.Count > 0)
            {
                int sindex = studentsListview.SelectedIndices[0];
                int cindex = coursesListview.SelectedIndices[0];
                int gindex = gradesListbox.SelectedIndex;
                if (gindex < 0)
                    MessageBox.Show("Select a grade for removing!");
                else
                {
                    studentsList[sindex].CourseList[cindex].RemoveGrade(gindex);
                    MessageBox.Show("Grade has been removed!");
                    gradesListbox.Items.Clear();
                    for (int j = 0; j < studentsList[sindex].CourseList[cindex].ListOfGrades.Length; j++)
                    {
                        gradesListbox.Items.Add(studentsList[sindex].CourseList[cindex].ListOfGrades[j]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Course!");
            }
        }

        private void btnChangeLastGrade_Click(object sender, EventArgs e)
        {
            try
            {                
                if (coursesListview.SelectedIndices.Count > 0)
                {
                    int sindex = studentsListview.SelectedIndices[0];
                    int cindex = coursesListview.SelectedIndices[0];
                    double NewGrade = double.Parse(txtChangeLastGrade.Text.Trim());
                    if ((NewGrade < 0) || (NewGrade > 100))
                        MessageBox.Show("Invalid grade!");
                    else
                    {
                        gradesListbox.Items.Clear();
                        studentsList[sindex].CourseList[cindex].ChangeLastGrade(NewGrade);
                        MessageBox.Show("Grade has been changed!");                        
                        for (int j = 0; j < studentsList[sindex].CourseList[cindex].ListOfGrades.Length; j++)
                        {
                            gradesListbox.Items.Add(studentsList[sindex].CourseList[cindex].ListOfGrades[j]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Course!");
                }

            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnDisplayFailingStudents_Click(object sender, EventArgs e)
        {
            List<Student> FailStuList = new List<Student>();
            
            for (int i = 0; i < studentsList.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < studentsList[i].CourseList.Length; j++)
                {
                    counter = 0;
                    for (int k = 0; k < studentsList[i].CourseList[j].ListOfGrades.Length; k++)
                    {
                        if (studentsList[i].CourseList[j].ListOfGrades[k] < 70)
                        {
                            for (int a = 0; a < FailStuList.Count; a++)
                            {
                                if (FailStuList[a] == studentsList[i])
                                {
                                    counter++;
                                }
                            }
                            if (counter == 0)
                            {
                                FailStuList.Add(studentsList[i]);
                            }
                        }
                    }
                }
            }
            DisplayStudents(FailStuList);
        }

        private void btnDisplayAllStudents_Click(object sender, EventArgs e)
        {
            DisplayStudents(studentsList);
        }

        private void btnDisplayStudentAbove88Gr_Click(object sender, EventArgs e)
        {
            List<Student> FailStuList = new List<Student>();
            
            for (int i = 0; i < studentsList.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < studentsList[i].CourseList.Length; j++)
                {
                    for (int k = 0; k < studentsList[i].CourseList[j].ListOfGrades.Length; k++)
                    {
                        if (studentsList[i].CourseList[j].ListOfGrades[k] >88)
                        {
                            for (int a = 0; a < FailStuList.Count; a++)
                            {
                                if (FailStuList[a] == studentsList[i])
                                {
                                    counter++;
                                }
                            }
                            if (counter == 0)
                            {
                                FailStuList.Add(studentsList[i]);
                            }
                        }
                    }
                }
            }
            DisplayStudents(FailStuList);
        }
    }
}
//Lab: Due Friday 9/30/2016 before class starts 
//add to this project
//1. Add at least 3 more students with 2 to 3 courses and each course
//   up to 5 grades
//2. Add the connection between coursesListview and gradesList
/// so when a course is selected, its grades are displayed in the 
/// listbox
/// ==========================Additional Functionalities============================================
/// 3. Be able to add a course to selected student
/// 4. Be able to remove a course of selected student
/// 5. Be able to add a grade, remoove a grade, or change last grade of selected course (of selected student)
/// 6. Be able to display all the (failling) student
/// (Whose average grade is less than 70)
/// 7. Display all the students whose avarage grade is above 88
