using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Samples
{
    public class Calc
    {
        public long Add(int p1, int p2)
        {
            return p1 + p2;
        }

        public int Div(int p1, int p2)
        {
            return p1 / p2;       
        }

        public double Divd(double p1, double p2)
        {
            return p1 / p2;
        }
    }
}
