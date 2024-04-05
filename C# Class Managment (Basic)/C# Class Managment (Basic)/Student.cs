using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__Class_Managment__Basic_
{
    internal class Student
    {
        private static int _id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }
        public int Id { get; set; }
        public string? GroupNo { get; private set; }
        public int StudentLimit { get; private set; }

        public Student()
        {
            _id++;
            Id = _id;
        }
       
        //public void AddNewStudentInfo()
        //{   Student student = new Student();
        //    string GroupNo;
        //    string Studentlimitstr;
        //    int Studentlimit;
        //    Console.WriteLine("GroupNo daxil et");
        //    GroupNo = Console.ReadLine();
        //    do
        //    {
        //        Console.WriteLine("Studentlimit teyin edin:");
        //        Studentlimitstr = Console.ReadLine();
        //        int.TryParse(Studentlimitstr, out Studentlimit);


        //    }
        //    while (!(Studentlimit >= 5 && Studentlimit <= 18));
        //    student.GroupNo = GroupNo;
        //    student.StudentLimit = Studentlimit;
            
        //}
        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Fullname} {Point}");
        }


    }
}
