
namespace inherinng.Entities
{
    class SavingAccount : Account
    {
        public double InteresRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interesRate)
            :base(number, holder, balance)
        {
            InteresRate = interesRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
