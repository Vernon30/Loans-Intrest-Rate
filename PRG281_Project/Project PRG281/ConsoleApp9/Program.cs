using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] loans = new string[5];
            LoanConstants loanConstants = new LoanConstants();

            Console.Write("Enter the current prime interest rate: ");
            double interestRate = double.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                bool validLoanType = false;

                Console.WriteLine(($"Loan Number: {i + 1}"));

                Console.Write("\nEnter the customer last Name: ");
                string customerLastName = Console.ReadLine();

                Console.Write("\nEnter the customer first name: ");
                string customerFirstName = Console.ReadLine();

                double loanAmount = 0;
                do
                {
                    string message = "\nEnter the loan amount: ";

                    if (loanAmount > loanConstants.MaximumLoan)
                    {
                        message = "This loan amount is not valid, enter a valid amount: ";
                    }

                    Console.Write(message);
                    loanAmount = double.Parse(Console.ReadLine());

                } while (loanAmount > loanConstants.MaximumLoan);

                Console.WriteLine("\nEnter the loan term:\n1: Short-term (1 year)\n2: Medium-term (3 years)\n3: Long-term (5 years)");
                int term = int.Parse(Console.ReadLine());

                switch (term)
                {
                    case 1:
                        term = loanConstants.ShortTerm;
                        break;
                    case 2:
                        term = loanConstants.MediumTerm;
                        break;
                    case 3:
                        term = loanConstants.LongTerm;
                        break;
                    default:
                        term = loanConstants.ShortTerm; 
                        break;

                }

                while (!validLoanType)
                {
                    Console.WriteLine("\nEnter the Loan type:\n1: Business Loan\n2: Personal Loan");
                    string loanType = Console.ReadLine();



                    if (loanType == "1")
                    {
                        BusinessLoan businessLoanObj = new BusinessLoan(customerLastName, customerFirstName, loanAmount, interestRate, term, i + 1);
                        loans[i] = businessLoanObj.ToString();
                        validLoanType = true;
                    }
                    else if (loanType == "2")
                    {
                        PersonalLoan personalLoanObj = new PersonalLoan(customerLastName, customerFirstName, loanAmount, interestRate, term, i + 1);
                        loans[i] = personalLoanObj.ToString();
                        validLoanType=true;
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option: \n");
                        validLoanType = false;
                    }

                }

                //Console.Clear();

            }

            Console.WriteLine();
            Console.WriteLine(loanConstants.CompanyName);
            Console.WriteLine($"{"Loan Number",-13} | {"Last Name",-13} | {"First Name",-13} | {"Term",-13} | {"Loan Amount",-13} | {"Total Loan",-13}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(loans[i]);
            }

            Console.ReadKey();


        }

        
    }
}
