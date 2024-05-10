using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public abstract class Loan
    {
        string customerLastName, customerFirstName;
        double loanAmount, interestRate;
        int term, loanNumber;

        protected Loan(string customerLastName, string customerFirstName, double loanAmount, double interestRate, int term, int loanNumber)
        {
            this.CustomerLastName = customerLastName;
            this.CustomerFirstName = customerFirstName;
            this.LoanAmount = loanAmount;
            this.InterestRate = interestRate;
            this.Term = term;
            this.LoanNumber = loanNumber;
        }

        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public int Term { get => term; set => term = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }

        public override string ToString()
        {
            return "";
        }
    }
}
