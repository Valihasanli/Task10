using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Class_Managment__Basic_
{
    internal class Group
    {
        public Group(string groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }

        public Group()
        {
        }

        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        public Student[] Students = { };
        public bool CheckGroupNo(string groupNo)
        {
            bool check = false;
            if (groupNo[0] >= 'A' && groupNo[0] <= 'Z' && groupNo[1] >= 'A' && groupNo[1] <= 'Z' && groupNo[2] >= '0' && groupNo[2] <= '9' && groupNo[3] >= '0' && groupNo[3] <= '9' && groupNo[4] >= '0' && groupNo[4] <= '9')
            { check = true; }
            return check;
        }
        public Student[] AddStudents(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            return Students;
        }
        public Student GetStudent(int id)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id) { return Students[i]; }
            }
            return null;

        }
        public Student[] GetAllStudents() { return Students; }
    }
}
