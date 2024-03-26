using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
    internal class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double LastMonthIndex { get; set; }

        public double ThisMonthIndex { get; set; }

        public int CustomerType { get; set; }

        public int NumberPeople { get; set; }



    }
}
