using System;

namespace DotNetClassDemo
{
    internal class Abstraction
    {
    }

    internal abstract class ParentClass
    {
        public abstract Boolean AssignFees(int StudentId, Decimal Discount, Decimal FeesAmount, Decimal TotalAmount);
        public abstract Decimal FeesCollection(int StudentId, Decimal FeesAmount, Decimal DiscountAmount, Decimal TotalAmount);
    }

    /* 1 Person */
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

    /* 2 Person */
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

}
