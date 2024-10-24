using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePOC.State
{
    internal interface IState
    {
        public double Min_Balance { get; set; }
        public double Max_Balance { get; set; }
        string GetBenifits();
    }
}
