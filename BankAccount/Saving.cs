using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Saving:Account
    {
        double min_amount = 1000;
        double min_withdraw = 1000;
        public override int OpenAccount(double amount, string name)
        {
               
            if (amount > min_amount)
            {
                num = num + 1;
                ac_no = num;
                user_name = name;
                balance = amount;
                return ac_no;

            }
            else
            {
                return 0;
            }
        }
        public override bool withdraw(double amount)
        {
            if (amount > min_withdraw && amount<balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
