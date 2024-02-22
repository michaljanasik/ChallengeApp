using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    public class Statistics
    {
        public Statistics()
        {
            
        }
        public float  Min{ get; set; }
        public float Average { get; set; }
        public float  Max{ get; set; }
        public Statistics Getstatistics()
        {

            return  new Statistics();
        }
    }
}
