using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    public class Customer
    {
        //if we do define varaibles as public they will be accessed from outside of the class
        int _Custid;
        bool _Status;
        string _Cname;
        double _Balance;
        public Customer(int Custid, bool Status, string Cname, double Balance)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
        }
        public int Custid
        {
            get { return _Custid; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set { _Cname = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }
    }
}
