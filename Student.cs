using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_10
{
    public class Student:Employee
    {
        public string _section;
        static int _countStudent = 0;
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }
        public Student():base(0,0,0,null,true)
        {
            this._section = null;
        }
        public Student(int id, int salary, int age, string name, bool gender,string section) : base(id, salary,age, name, gender)
        {
            this.Section = section;
        }
        public int Count_number_student_by_section(Student[] students,string section)
        {
            for (int i = 0; i < students.Length; i++)
                if(students[i].Section == section)
                    _countStudent++;
            Console.WriteLine(" Section Name : {0}   Number of Students in this section : {1}",section,_countStudent);
            return _countStudent;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(" Section : {0}",this.Section);
        }
        public override void Print_Names_Females()
        {
            base.Print_Names_Females();
        }
        public override void Print_Names_Males()
        {
            base.Print_Names_Males();
        }

    }
}