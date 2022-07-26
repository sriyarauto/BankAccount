using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   public  class Fixed:Account
    {
        DateTime odt = new DateTime();
        DateTime md = new DateTime();
        int termperiod = 3;
        double min_amount = 10000;
        double min_withdraw = 10000;
        public override int OpenAccount(double amount, string name)
        {
            
            if (amount > min_amount)
            {
                num = num + 1;
                ac_no = num;
                user_name = name;
                balance = amount;
                odt = DateTime.Now;
                md=odt.AddYears(termperiod);
                return num;

            }
            else
            {
                return 0;
            }
        }
        public override bool withdraw(double amount)
        { DateTime cd = new DateTime();
            cd = DateTime.Now;
            if (cd>md)
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
