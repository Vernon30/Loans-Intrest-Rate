using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class PersonalLoan : Loan
    {

        public PersonalLoan(string customerLastname, string customerFirstName, double loanAmount, double interestRate, int term, int loanNumber) : base(customerLastname, customerFirstName, loanAmount, interestRate, term, loanNumber)
        {
            
        }
        public double GetInterestRate()
        {
            Console.WriteLine("Enter the current prime interest rate: ");
            InterestRate = double.Parse(Console.ReadLine());
            return InterestRate;
        }

        public double ExtendInterestRate()
        {
            return InterestRate + 2;
        }

        public string CalcTotalLoan()
        {
            return (LoanAmount * (1 + (ExtendInterestRate() / 100) * Term)).ToString();
        }

        public override string ToString()
        {
            return $"{LoanNumber,-13} | {CustomerLastName,-13} | {CustomerFirstName,-13} | {Term,-13} | {LoanAmount,-13} | {CalcTotalLoan(),-13}";
        }
    }
}
