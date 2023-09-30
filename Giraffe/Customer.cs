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
        string _Cname,_City;
        double _Balance;
        public Customer(int Custid, bool Status, string Cname, double Balance,string City)
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
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
        public string City
        {
            get { return _City; }
            set
            {
                if(_Status == true)
                {
                    if (value == "Delhi" || value=="Mumbai" || value =="İstanbul")
                    {
                        _City = value;
                    }
                   
                }
            }
        }
    }
}
