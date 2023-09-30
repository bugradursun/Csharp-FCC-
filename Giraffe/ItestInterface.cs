using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    interface ItestInterface1
    {
        void Add(int a, int b);
    }
    interface ItestInterface2 : ItestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass: ItestInterface1
    {
        public void Add(int a , int b) {
            Console.WriteLine(a + b);
        }
        public void Sub(int a , int b)
        {
            Console.WriteLine(a - b);
        }
        // static void Main()
        //   {
        //   ImplementationClass obj = new ImplementationClass();
        //   obj.Add(1, 4);obj.Sub(10, 6);
        //   Console.ReadLine();
        // }
    }
}
