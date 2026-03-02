namespace Chain_of_Responsibility.context
{
    public class LoanContext
    {
        private string name;
        private double amount;
        private int creditScore;
        private double income;
        private double dtl;

        public LoanContext(string name, double amount, int creditScore, double income, double debt)
        {
            this.name = name;
            this.amount = amount;
            this.creditScore = creditScore;
            this.income = income;
            this.dtl = debt / income;
        }

        public string getName()
        {
            return name;
        }

        public double getAmount()
        {
            return amount;
        }

        public int getCreditScore()
        {
            return creditScore;
        }

        public double getIncome()
        {
            return income;
        }

        public double getDTL()
        {
            return dtl;
        }
    }
}