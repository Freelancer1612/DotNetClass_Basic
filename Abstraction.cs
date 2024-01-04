using System;

namespace DotNetClassDemo
{
    internal class Abstraction
    {
        /* What is Abstraction in C#?
         * The process of representing the essential features without including the background details is called Abstraction.
         * In simple words, we can say that it is a process of defining a class by providing the necessary details to call the object operations (i.e., methods) by hiding its implementation details.
         */

        /* How to Implement Abstraction Principle in C#? 
         * 1) Using Abstract Classes and Abstract Methods
         * 2) Using Interface
         */

    }

    /* ===== */
    /* Abstract Classes and Abstract Methods */
    #region "Abstract Classes and Abstract Methods"

    /* Abstract Classes  */
    internal abstract class ParentClass
    {
        public abstract Boolean AssignFees(int StudentId, Decimal Discount, Decimal FeesAmount, Decimal TotalAmount);
        public abstract Decimal FeesCollection(int StudentId, Decimal FeesAmount, Decimal DiscountAmount, Decimal TotalAmount);
    }

    /* 1 Person (Abstract Methods) */
    internal class FeesModule : ParentClass
    {
        public override bool AssignFees(int StudentId, decimal Discount, decimal FeesAmount, decimal TotalAmount)
        {
            throw new NotImplementedException();
        }

        public override decimal FeesCollection(int StudentId, decimal FeesAmount, decimal DiscountAmount, decimal TotalAmount)
        {
            throw new NotImplementedException();
        }
    }

    /* 2 Person (Abstract Methods) */
    internal class FeesCollectionModule : ParentClass
    {
        public override bool AssignFees(int StudentId, decimal Discount, decimal FeesAmount, decimal TotalAmount)
        {
            throw new NotImplementedException();
        }

        public override decimal FeesCollection(int StudentId, decimal FeesAmount, decimal DiscountAmount, decimal TotalAmount)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
    /* ===== */

    /* ===== */
    /* Interface */
    #region "Interface"
    /* An interface defines a contract.
     * An Interface in C# is a fully un-implemented class used for declaring only abstract members. 
     * So, we can also define an interface as a pure abstract class which allows us to define only abstract members especially abstract methods or abstract properties.
     * An abstract method is a method without a body or implementation.
     */
    interface IBankATM
    {
        void BankTransfer(string AccountNumber, Decimal Amount);
        void CheckBalanace(string AccountNumber);
        void MiniStatement(string AccountNumber);
    }
    public class SBIBankATM : IBankATM
    {
        public void BankTransfer(string AccountNumber, decimal Amount)
        {
            Console.WriteLine("SBI Bank Bank Transfered Successfully");
        }

        public void CheckBalanace(string AccountNumber)
        {
            Console.WriteLine("Your Available Balance is 10,000");
        }

        public void MiniStatement(string AccountNumber)
        {
            Console.WriteLine("Credit 4,000");
            Console.WriteLine("Credit 3,000");
            Console.WriteLine("Credit 3,000");
        }
    }
    public class IndianBankATM : IBankATM
    {
        public void BankTransfer(string AccountNumber, decimal Amount)
        {
            Console.WriteLine("Indian Bank Bank Transfered Successfully");
        }

        public void CheckBalanace(string AccountNumber)
        {
            Console.WriteLine("Your Available Balance is 10,000");
        }

        public void MiniStatement(string AccountNumber)
        {
            Console.WriteLine("Credit 4,000");
            Console.WriteLine("Credit 3,000");
            Console.WriteLine("Credit 3,000");
        }
    }
    #endregion
    /* ===== */

    /* ==== */
    /* Multiple Inheritance (Basically C# Not Support Multiple Inheritance) */
    #region "Multiple Inheritance"
    interface ITransaction
    {
        void Deposit(String AccountNumber, Decimal DepositAmount);
        void Withdraw(String AccountNumber, Decimal WithdrawAmount);
    }
    interface IStetement
    {
        void BalanceSheet(String AccountNumber);
    }
    public class NetBanking : ITransaction, IStetement
    {
        /* ITransaction */
        public void Deposit(string AccountNumber, decimal DepositAmount)
        {
            Console.WriteLine(DepositAmount + " Is Received.");
        }

        public void Withdraw(string AccountNumber, decimal WithdrawAmount)
        {
            Console.WriteLine(WithdrawAmount + " Is Transfered.");
        }

        /* IStetement */
        public void BalanceSheet(string AccountNumber)
        {
            Console.WriteLine("Deposit 4,000");
            Console.WriteLine("Withdraw 3,000");
            Console.WriteLine("Balance 1,000");
        }
    }
    #endregion
    /* ==== */

}
