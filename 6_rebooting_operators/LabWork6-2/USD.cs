using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork6_2
{
    class USD
    {
        protected double Course;
        protected string Month;

        public USD(string month, double course)
        {
            Month = month;
            Course = course;
        }
        public static implicit operator double(USD x)
        {
            return x.Course;
        }
        public static bool operator >(USD x, USD y)
        {
            return x.Course > y.Course;
        }
        public static bool operator <(USD x, USD y)
        {
            return x.Course < y.Course;
        }
    }
}
