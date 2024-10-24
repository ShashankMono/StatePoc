using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePOC.State
{
    internal class Platinium:IState
    {
        public double Min_Balance { get; set; }
        public double Max_Balance { get; set; }

        public Platinium(double min, double max)
        {
            Min_Balance = min;
            Max_Balance = max;
        }

        public string GetBenifits()
        {
            return "Your getting benifits of Platinium account holder ";
        }
    }
}
