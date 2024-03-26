using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    internal class Account
    {

        public string Name { get; set; }

        public double LastMonthIndex { get; set; } // chi so thang truoc 
        public double ThisMonthIndex { get; set;} // thang nay

        public int AccountType { get; set; } // loai tai khoan


        public String AccountTypeString { get; set; } // 


        public double TotalIndex { get; set; } // total index = thismonth - lastmonth

        public double Cost { get; set; } // Money

        public int PeopleCount { get; set; } // so nguoi trong gia dinh

        public Account() { }

    }
}
