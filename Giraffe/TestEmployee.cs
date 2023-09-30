using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class TestEmployee
    {
        static void Main()
        {
            Employee Emp = new Employee(1001, "Scott", "Manager", 20000.00, "Sales", "Mumbai");
            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Ename:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Salary:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);
            
            Console.ReadLine();
        }
    }
}
