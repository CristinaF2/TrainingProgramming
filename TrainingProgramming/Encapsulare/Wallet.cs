using System.Security.Cryptography.X509Certificates;

namespace TrainingProgramming.Encapsulare
{
    public class Wallet
    {
        private decimal balance { get; set; } 

        public Wallet(decimal initialAmount) 
        { 
              this.balance = initialAmount;
              
        
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance = balance +amount;
            }else
            {
                Console.WriteLine("Deposit amount must be positive");
            }
        }


        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount<=balance)
            {
                balance = balance -amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
        }

       // public decimal GetBalance() { return balance; }

       /*  public decimal Balance
        {
            get { return balance; }
         
        }
       */

    }
}
