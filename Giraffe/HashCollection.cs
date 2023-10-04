using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class HashCollection
    {
       public int Custid { get; set; }
       public string Name { get; set; }
       public string City { get; set; }
       public double Balance { get; set; }
    }

    class TestCustomerr
    {
        static void Main()
        {
            List<HashCollection> Customers = new List<HashCollection>();
            HashCollection c1 = new HashCollection { Custid = 101, Name = "Scott", City = "Istanbul", Balance  = 25000.00 };
            HashCollection c2 = new HashCollection { Custid = 101, Name = "Smith", City = "London", Balance = 45000.00 };
            HashCollection c3 = new HashCollection { Custid = 101, Name = "Dave", City = "Madrid", Balance = 65000.00 };
            HashCollection c4 = new HashCollection { Custid = 101, Name = "David", City = "Berlin", Balance = 85000.00 };

            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);
            Customers.Add(c4);

            foreach(HashCollection obj in Customers)
            {
                Console.WriteLine(obj.Custid + " " + obj.Name + "" + obj.City + " " + obj.Balance);
                Console.ReadLine();
            }

        }
    }
}
