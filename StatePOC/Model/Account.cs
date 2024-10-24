using StatePOC.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePOC.Model
{
    internal class Account
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public IState State;

        public Account(int id,string name,double balance,IState state)
        {
            Id = id;
            Name = name;
            Balance = balance;
            State = state;
        }

        public void Deposite(double amount)
        {
            Balance += amount;
            State = StateEvalution.EvaluateState(this);
        }

        public void Withdraw (double amount)
        {
            Balance -= amount;
            State = StateEvalution.EvaluateState(this);
        }
    }
}
