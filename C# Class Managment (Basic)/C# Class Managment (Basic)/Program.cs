using System.Globalization;
using System.Text.RegularExpressions;

namespace C__Class_Managment__Basic_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int point;
            string pointstr;
            string GroupNo;
            int Studentlimit;
            string Studentlimitstr;
            int Id;
            Console.WriteLine("FullName daxil edin:");
            string fullname = Console.ReadLine();
            do
            {
                Console.WriteLine("Point daxil et:");
                pointstr = Console.ReadLine();
            }
            while (!int.TryParse(pointstr, out point));
            Student student = new Student();
            student.Point = point;
            student.Fullname = fullname;
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Create new group");
            string answer = Console.ReadLine();
            Group group = new Group();
            group.AddStudents(student);
            switch (answer)
            {
                case "1":
                    student.ShowInfo();
                    break;
                case "2":

                    //group.AddStudents(student.AddNewStudentInfo());metod yazdim ama chagira bilmedim
                    {
                        Console.WriteLine("GroupNo daxil et");
                        GroupNo = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Studentlimit teyin edin:");
                            Studentlimitstr = Console.ReadLine();
                            int.TryParse(Studentlimitstr, out Studentlimit);


                        }
                        while (!(Studentlimit >= 5 && Studentlimit <= 18));
                        group.GroupNo = GroupNo;
                        group.StudentLimit = Studentlimit;
                        break;
                    }

                default:
                    Console.WriteLine("Duzgun sechim et");
                    break;
            }
            bool check = true;
            while (check)
            {
                Console.WriteLine("1. Show all students");
                Console.WriteLine("2. Get student by id");
                Console.WriteLine("3. Add student");
                Console.WriteLine("0. Quit");
                string cavab = Console.ReadLine();

                switch (cavab)
                {
                    case "1":
                        {
                            for (int i = 0; i < group.GetAllStudents().Length; i++)
                            {
                                group.GetAllStudents()[i].ShowInfo();
                            }
                        }

                        break;
                    case "2":
                        {
                            Console.WriteLine("ID daxil et");
                            string ID = Console.ReadLine();
                            int.TryParse(ID, out Id);
                            group.GetStudent(Id).ShowInfo();

                        }
                        break;
                    case "3":
                        {
                            int point1;
                            string pointstr1;

                            Console.WriteLine("FullName daxil edin:");
                            string fullname1 = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Point daxil et:");
                                pointstr1 = Console.ReadLine();
                            }
                            while (!int.TryParse(pointstr1, out point1));
                            Student student1 = new Student();
                            student1.Point = point1;
                            student1.Fullname = fullname1;
                            group.AddStudents(student1);
                        }
                        break;
                    case "0":
                        Console.WriteLine("proqramdan chixdin");
                        check = false;
                        break;
                }

            }
        }

    }
}

