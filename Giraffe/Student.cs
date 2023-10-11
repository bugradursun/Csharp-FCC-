using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    // we are sorting with interfaces in this example
    //sorting mechanism in user defined types
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; } 
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Sid = 103, Name = "Bugra", Class = 10, Marks = 575.00f };
            Student s2 = new Student { Sid = 105, Name = "Ahmet", Class = 10, Marks = 595.00f };
            Student s3 = new Student { Sid = 101, Name = "Williams", Class = 10, Marks = 592.00f };
            Student s4 = new Student { Sid = 108, Name = "David", Class = 10, Marks = 515.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4 }; //adding custom defined user type(student) to our list
            CompareStudents obj = new CompareStudents();
            Students.Sort(obj);
            foreach (Student S in Students)
            {
                Console.WriteLine(S.Sid + "" + S.Name + "" + S.Class + S.Marks);

            }
            Console.ReadLine();
        }
    }
}