using StatePOC.Model;
using StatePOC.State;

namespace StatePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Here is state design pattern one state gets changed to next or another state internally
            // without knowing to the client or the user.
            // the states are kept together using interface so that we can use them or access them using
            // a single reference of the parent. we can take many examples like user login to an application
            // state I- login credential , II- Authentication , III- session creation, IV- Authorization.
            // current code example is of account lies in which category as per the account balance and getting
            // the benifits accordingly.
            Account account1 = new Account(101,"James",5000,new Basic(0,10000));
            StateEvalution.AddNewState(new Basic(0,10000));
            StateEvalution.AddNewState(new Silver( 10001,20000));
            StateEvalution.AddNewState(new Gold(20001, 35000));
            StateEvalution.AddNewState(new Platinium(35001,50000));

            Console.WriteLine(account1.State.GetBenifits());
            account1.Deposite(10000);
            Console.WriteLine(account1.State.GetBenifits());

        }
    }
}
