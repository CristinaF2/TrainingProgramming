namespace TrainingProgramming.Encapsulare
{
    public class BankTest
    {
        private Wallet wallet;

        [SetUp]
        public void Setup()
        {
            wallet= new Wallet(2500);
        }

        [Test]
        public void TestDeposit()
        {
            wallet.Deposit(500);
           // Console.WriteLine(wallet.GetBalance());
        }

        [Test]
        public void TestWithdraw()
        {
            wallet.Withdraw(500);
            //Console.WriteLine(wallet.GetBalance());
          //  Console.WriteLine(wallet.Balance);
        }

       
    }
}
