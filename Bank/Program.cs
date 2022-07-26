using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;
namespace Bank
{
    class Program
    {    
        static void Main(string[] args)
        { Account[] bank_ac = new Account[5];

            int acc_no;

            double amount;
            string name;
            Account ac=null;
            int i = 0;
            string ch;
            
            while(true)
            {
                Console.WriteLine("Select Operation");
                Console.WriteLine("1.OpenAccount");
                Console.WriteLine("2.Deposite");
                Console.WriteLine("3.Withdraw");
                Console.WriteLine("4.Check Balance");
                Console.WriteLine("5.Close Account");
                Console.WriteLine("6.Exit");
                ch=Console.ReadLine();
                switch(ch)
                {
                    case "1":
                        Console.WriteLine("Choose Type");
                        Console.WriteLine("1.Saving");
                        Console.WriteLine("2.Current");
                        Console.WriteLine("3.Fixed");
                        string c = Console.ReadLine();
                        if(c=="1")
                        {
                            ac = new Saving();
                            
                        }
                        else if(c=="2")
                        {
                            ac= new Current();
                           
                        }
                        else if(c=="3")
                        {
                          ac = new Fixed();
                           
                        }
                        Console.WriteLine("Enter your Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the amount");
                        amount = Convert.ToDouble(Console.ReadLine());

                        int acno = ac.OpenAccount(amount, name);
                        bank_ac[i++] = ac;
                        if(acno!=0)
                            Console.WriteLine("Your account number is ......" + acno);
                        else
                        {
                            Console.WriteLine("Sorry! couldn't Create account.....");
                        }

                        break;
                    case "2":
                        Console.WriteLine("Enter your account number");
                        acc_no = Convert.ToInt32(Console.ReadLine());
                        
                      
                        for(int j=0;j<5; j++)
                        { Account a = bank_ac[j];
                            if(a.Accountno==acc_no)
                            {
                                Console.WriteLine("Enter the amount to be deposit");
                                amount = Convert.ToDouble(Console.ReadLine());
                                if (a.deposite(amount))
                                {
                                    Console.WriteLine("Amount Deposited");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry! couldn't Deposite");
                                }
                                break;
                            }
                        }
                     
                       
                        break;
                    case "3":
                        Console.WriteLine("Enter your account number");
                        acc_no = Convert.ToInt32(Console.ReadLine());
                            
                      
                        for (int j = 0; j < 5; j++)
                        {
                            Account a = bank_ac[j];
                            if (a.Accountno == acc_no)
                            {

                                Console.WriteLine("Enter the amount to withdraw");
                                amount = Convert.ToDouble(Console.ReadLine());
                                if (a.withdraw(amount))
                                {
                                    Console.WriteLine("Transaction succesful");
                                }
                                else
                                {
                                    Console.WriteLine("Transaction fail");
                                }
                                break;
                            }
                        }

                        
                        break;
                    case "4":
                        Console.WriteLine("Enter your account number");
                        acc_no = Console.Read();
                        for (int j = 0; j < 5; j++)
                        {
                            Account a = bank_ac[j];
                            if (a.Accountno == acc_no)
                            {

                                Console.WriteLine(a.check_balance);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Enter your account number");
                        acc_no=Console.Read();
                        for (int j = 0; j < 5; j++)
                        {
                            Account a = bank_ac[j];
                            if (a.Accountno == acc_no)
                            {
                                bank_ac[j] = null;
                                Console.WriteLine(ac.close());
                            }

                        }

                        break;
                    case "6":
                        break;
                        //break;
                    default:
                        Console.WriteLine("Select a correct choice");
                        break;


                }

            }
        }
    }
}
