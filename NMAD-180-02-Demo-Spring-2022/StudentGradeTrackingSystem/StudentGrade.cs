using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeTrackingSystem
{
    class StudentGrade
    {
        private int grade;
        private string name;
        private string course;

        public StudentGrade()
        {
            grade = -1;
            name= "N/A";
            course = "N/A";
        }

        public StudentGrade(int grade1)
        {
            Grade = grade1;
        }

        public StudentGrade(int grade1, string name, string course)
        {

        }

        public int Grade {
            get
            {
                return grade;
            }
            set
            {
                if (value >= 0)
                    grade = value;
            } 
        }
        public string Course { get; set; }

        //public void SetGrade(int _grade)
        //{
        //    grade = _grade;
        //}

        //public int GetGrade()
        //{
        //    return grade;
        //}
    }
}
