namespace Packt.Shared
{
    public class BankAccount
    {
        
        /*
         * each instance will have there own name and balance,
         * but will each instance will share the interest rate
         */
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate;
    }
}