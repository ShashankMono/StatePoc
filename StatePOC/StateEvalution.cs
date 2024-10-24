using StatePOC.Model;
using StatePOC.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePOC
{
    internal class StateEvalution
    {
        public static List<IState> states = new List<IState>();
        //states.Add();
        public static IState EvaluateState(Account account)
        {
            foreach (IState state in states) {
                if (account.Balance > state.Min_Balance && account.Balance < state.Max_Balance) 
                    return state;
            }
            return null; 
        }

        public static void AddNewState(IState state) {
            states.Add(state); 
        }
    }
}
