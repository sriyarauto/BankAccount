using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     public class Current:Account
    {
        double min_amount = 5000;
        double oda= 5000;
        public override int  OpenAccount(double amount,string name)
        {
            
            if(amount>min_amount)
            {
                num = num + 1;
                ac_no=num;
                user_name = name;
                balance = amount;
                return num;

            }
            else
            {
                return 0;
            }
        }
        public override bool withdraw(double amount)
        {
            if(amount<balance+oda)
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
