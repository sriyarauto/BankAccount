using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     public abstract class Account
    {
        protected static int num=0;
        protected string user_name;
        protected double balance;
        protected double amount;
        protected int ac_no;
        //Open
        public abstract int OpenAccount(double amount,string name);
        public abstract bool withdraw(double amount);
       public  virtual bool deposite(double amount)
        {   if (amount > 0)
            {
                balance = balance + amount;
                return true;
            }
            else
                return false;
        }
        public double check_balance
        {    
            get{
                return balance;
            }
        }
        public int Accountno
        {
            get
            {
                return ac_no;
            }
        }
        public string close()
        {
            return "Acccount Closed";
        }


    }
}
