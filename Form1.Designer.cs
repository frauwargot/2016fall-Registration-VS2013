namespace Object_containing_list_of_objects
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coursesListview = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gradesListbox = new System.Windows.Forms.ListBox();
            this.btnAddCourseToSelectedStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveSelectedCourse = new System.Windows.Forms.Button();
            this.txtNewGrade = new System.Windows.Forms.TextBox();
            this.btnAddNewGrade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoveSelectedGrade = new System.Windows.Forms.Button();
            this.btnChangeLastGrade = new System.Windows.Forms.Button();
            this.txtChangeLastGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayAllStudents = new System.Windows.Forms.Button();
            this.btnDisplayFailingStudents = new System.Windows.Forms.Button();
            this.btnDisplayStudentAbove88Gr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsListview
            // 
            this.studentsListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.studentsListview.FullRowSelect = true;
            this.studentsListview.GridLines = true;
            this.studentsListview.Location = new System.Drawing.Point(13, 13);
            this.studentsListview.Margin = new System.Windows.Forms.Padding(4);
            this.studentsListview.Name = "studentsListview";
            this.studentsListview.Size = new System.Drawing.Size(369, 212);
            this.studentsListview.TabIndex = 0;
            this.studentsListview.UseCompatibleStateImageBehavior = false;
            this.studentsListview.View = System.Windows.Forms.View.Details;
            this.studentsListview.SelectedIndexChanged += new System.EventHandler(this.studentsListview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "LastName";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 180;
            // 
            // coursesListview
            // 
            this.coursesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.coursesListview.FullRowSelect = true;
            this.coursesListview.GridLines = true;
            this.coursesListview.Location = new System.Drawing.Point(390, 13);
            this.coursesListview.Margin = new System.Windows.Forms.Padding(4);
            this.coursesListview.Name = "coursesListview";
            this.coursesListview.Size = new System.Drawing.Size(365, 212);
            this.coursesListview.TabIndex = 1;
            this.coursesListview.UseCompatibleStateImageBehavior = false;
            this.coursesListview.View = System.Windows.Forms.View.Details;
            this.coursesListview.SelectedIndexChanged += new System.EventHandler(this.coursesListview_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course ID";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course Name";
            this.columnHeader4.Width = 240;
            // 
            // gradesListbox
            // 
            this.gradesListbox.FormattingEnabled = true;
            this.gradesListbox.ItemHeight = 16;
            this.gradesListbox.Location = new System.Drawing.Point(763, 13);
            this.gradesListbox.Margin = new System.Windows.Forms.Padding(4);
            this.gradesListbox.Name = "gradesListbox";
            this.gradesListbox.Size = new System.Drawing.Size(150, 212);
            this.gradesListbox.TabIndex = 2;
            // 
            // btnAddCourseToSelectedStudent
            // 
            this.btnAddCourseToSelectedStudent.Location = new System.Drawing.Point(17, 288);
            this.btnAddCourseToSelectedStudent.Name = "btnAddCourseToSelectedStudent";
            this.btnAddCourseToSelectedStudent.Size = new System.Drawing.Size(365, 29);
            this.btnAddCourseToSelectedStudent.TabIndex = 3;
            this.btnAddCourseToSelectedStudent.Text = "Add Course to Selected Student";
            this.btnAddCourseToSelectedStudent.UseVisualStyleBackColor = true;
            this.btnAddCourseToSelectedStudent.Click += new System.EventHandler(this.btnAddCourseToSelectedStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Course ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(17, 259);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(128, 23);
            this.txtCourseID.TabIndex = 5;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(151, 259);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(231, 23);
            this.txtCourseName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Course Name:";
            // 
            // btnRemoveSelectedCourse
            // 
            this.btnRemoveSelectedCourse.Location = new System.Drawing.Point(389, 229);
            this.btnRemoveSelectedCourse.Name = "btnRemoveSelectedCourse";
            this.btnRemoveSelectedCourse.Size = new System.Drawing.Size(366, 29);
            this.btnRemoveSelectedCourse.TabIndex = 8;
            this.btnRemoveSelectedCourse.Text = "Remove Selected Course";
            this.btnRemoveSelectedCourse.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedCourse.Click += new System.EventHandler(this.btnRemoveSelectedCourse_Click);
            // 
            // txtNewGrade
            // 
            this.txtNewGrade.Location = new System.Drawing.Point(764, 251);
            this.txtNewGrade.Name = "txtNewGrade";
            this.txtNewGrade.Size = new System.Drawing.Size(60, 23);
            this.txtNewGrade.TabIndex = 9;
            // 
            // btnAddNewGrade
            // 
            this.btnAddNewGrade.Location = new System.Drawing.Point(830, 251);
            this.btnAddNewGrade.Name = "btnAddNewGrade";
            this.btnAddNewGrade.Size = new System.Drawing.Size(83, 23);
            this.btnAddNewGrade.TabIndex = 10;
            this.btnAddNewGrade.Text = "Add";
            this.btnAddNewGrade.UseVisualStyleBackColor = true;
            this.btnAddNewGrade.Click += new System.EventHandler(this.btnAddNewGrade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter New Grade:";
            // 
            // btnRemoveSelectedGrade
            // 
            this.btnRemoveSelectedGrade.Location = new System.Drawing.Point(765, 281);
            this.btnRemoveSelectedGrade.Name = "btnRemoveSelectedGrade";
            this.btnRemoveSelectedGrade.Size = new System.Drawing.Size(147, 43);
            this.btnRemoveSelectedGrade.TabIndex = 12;
            this.btnRemoveSelectedGrade.Text = "Remove Selected Grade";
            this.btnRemoveSelectedGrade.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedGrade.Click += new System.EventHandler(this.btnRemoveSelectedGrade_Click);
            // 
            // btnChangeLastGrade
            // 
            this.btnChangeLastGrade.Location = new System.Drawing.Point(754, 329);
            this.btnChangeLastGrade.Name = "btnChangeLastGrade";
            this.btnChangeLastGrade.Size = new System.Drawing.Size(157, 31);
            this.btnChangeLastGrade.TabIndex = 13;
            this.btnChangeLastGrade.Text = "Change last grade!";
            this.btnChangeLastGrade.UseVisualStyleBackColor = true;
            this.btnChangeLastGrade.Click += new System.EventHandler(this.btnChangeLastGrade_Click);
            // 
            // txtChangeLastGrade
            // 
            this.txtChangeLastGrade.Location = new System.Drawing.Point(698, 333);
            this.txtChangeLastGrade.Name = "txtChangeLastGrade";
            this.txtChangeLastGrade.Size = new System.Drawing.Size(50, 23);
            this.txtChangeLastGrade.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter new grade:";
            // 
            // btnDisplayAllStudents
            // 
            this.btnDisplayAllStudents.Location = new System.Drawing.Point(17, 395);
            this.btnDisplayAllStudents.Name = "btnDisplayAllStudents";
            this.btnDisplayAllStudents.Size = new System.Drawing.Size(365, 30);
            this.btnDisplayAllStudents.TabIndex = 17;
            this.btnDisplayAllStudents.Text = "Display all students";
            this.btnDisplayAllStudents.UseVisualStyleBackColor = true;
            this.btnDisplayAllStudents.Click += new System.EventHandler(this.btnDisplayAllStudents_Click);
            // 
            // btnDisplayFailingStudents
            // 
            this.btnDisplayFailingStudents.Location = new System.Drawing.Point(17, 323);
            this.btnDisplayFailingStudents.Name = "btnDisplayFailingStudents";
            this.btnDisplayFailingStudents.Size = new System.Drawing.Size(365, 30);
            this.btnDisplayFailingStudents.TabIndex = 18;
            this.btnDisplayFailingStudents.Text = "Display all the failling student";
            this.btnDisplayFailingStudents.UseVisualStyleBackColor = true;
            this.btnDisplayFailingStudents.Click += new System.EventHandler(this.btnDisplayFailingStudents_Click);
            // 
            // btnDisplayStudentAbove88Gr
            // 
            this.btnDisplayStudentAbove88Gr.Location = new System.Drawing.Point(17, 359);
            this.btnDisplayStudentAbove88Gr.Name = "btnDisplayStudentAbove88Gr";
            this.btnDisplayStudentAbove88Gr.Size = new System.Drawing.Size(365, 30);
            this.btnDisplayStudentAbove88Gr.TabIndex = 19;
            this.btnDisplayStudentAbove88Gr.Text = "Display all student with grade above 88";
            this.btnDisplayStudentAbove88Gr.UseVisualStyleBackColor = true;
            this.btnDisplayStudentAbove88Gr.Click += new System.EventHandler(this.btnDisplayStudentAbove88Gr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(921, 438);
            this.Controls.Add(this.btnDisplayStudentAbove88Gr);
            this.Controls.Add(this.btnDisplayFailingStudents);
            this.Controls.Add(this.btnDisplayAllStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChangeLastGrade);
            this.Controls.Add(this.btnChangeLastGrade);
            this.Controls.Add(this.btnRemoveSelectedGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewGrade);
            this.Controls.Add(this.txtNewGrade);
            this.Controls.Add(this.btnRemoveSelectedCourse);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCourseToSelectedStudent);
            this.Controls.Add(this.gradesListbox);
            this.Controls.Add(this.coursesListview);
            this.Controls.Add(this.studentsListview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentsListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView coursesListview;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListBox gradesListbox;
        private System.Windows.Forms.Button btnAddCourseToSelectedStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveSelectedCourse;
        private System.Windows.Forms.TextBox txtNewGrade;
        private System.Windows.Forms.Button btnAddNewGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoveSelectedGrade;
        private System.Windows.Forms.Button btnChangeLastGrade;
        private System.Windows.Forms.TextBox txtChangeLastGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplayAllStudents;
        private System.Windows.Forms.Button btnDisplayFailingStudents;
        private System.Windows.Forms.Button btnDisplayStudentAbove88Gr;
    }
}

