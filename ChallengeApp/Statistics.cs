﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challangeApp
{
    public class Statistics
    {

        float min, max, average;

        public Statistics()
        {
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.Average = 0;
        }

        //--------------------functions-------
        public float Min
        {
            get { return this.min; }
            set { this.min = value; }
        }
        public float Average
        {
            get { return this.average; }
            set { this.average = value; }
        }
        public float Max
        {
            get { return this.max; }
            set { this.max = value; }
        }


    }



}

