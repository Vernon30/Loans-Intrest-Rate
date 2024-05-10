using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public interface ILoanConstants
    {
        string CompanyName { get; }
        double MaximumLoan { get; }
        int ShortTerm { get; }
        int MediumTerm { get; }
        int LongTerm { get; }
    }
    public class LoanConstants : ILoanConstants
    {
        public string CompanyName { get; } = "ChamberLoans";
        public double MaximumLoan { get; } = 100000;
        public int ShortTerm { get; } = 1;
        public int MediumTerm { get; } = 3;
        public int LongTerm { get; } = 5;
    }
}
