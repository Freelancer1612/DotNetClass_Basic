using System;

namespace DotNetClassDemo
{
    internal class Polymorphism
    {
        public Polymorphism()
        {
            /* What is Polymorphism? */
            /* Polymorphism means  "one name many forms." "Poly" means many, and "morph" means forms.
             * In other words, one object has many forms or has one name with multiple functionalities. 
             * Polymorphism allows a class to have multiple implementations with the same name. 
             */

            /* What are types Polymorphism support in C# ? */
            // 1) Static / Compile Time Polymorphism
            // 2) Dynamic / Runtime Polymorphism



            /* Static Polymorphism Examples (Method Overload) */
            StaticPolymorphism ObjStatic = new StaticPolymorphism();
            int BiggestNum_From2Num = ObjStatic.FindMaxNumber(5, 8);
            int BiggestNum_From3Num = ObjStatic.FindMaxNumber(5, 8, 10);

            /* Dynamic / Runtime Polymorphism Example (Method Override) */
            DynamicPolymorphism ObjDynamic = new DynamicPolymorphism();
            Decimal BestDiscountAmount = ObjDynamic.GetDiscountAmount(1000);


        }



    }

    /* ==== */
    /* Static / Compile Time Polymorphism */
    #region "Static Polymorphism"
    public class StaticPolymorphism
    {
        /* Method Over Loading */
        public int FindMaxNumber(int A, int B)
        {
            if (A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
        public int FindMaxNumber(int A, int B, int C)
        {
            if (A > B)
            {
                return A;
            }
            else if (B > C)
            {
                return B;
            }
            else
            {
                return C;
            }
        }
    }
    #endregion
    /* ==== */

    /* ==== */
    /* Dynamic / Runtime Polymorphism */
    #region "Dynamic Polymorphism"
    public class DefaultDiscount
    {
        public decimal GetDiscountAmount(decimal TotalAmount)
        {
            /* Default Discount Percentage */
            decimal Percentage = 20;
            return (TotalAmount / 100) * Percentage;
        }
    }
    public class DynamicPolymorphism : DefaultDiscount
    {
        public decimal GetDiscountAmount(decimal TotalAmount)
        {
            /* Default Discount Percentage */
            decimal Percentage = 40;
            return (TotalAmount / 100) * Percentage;
        }
    }
    #endregion
    /* ==== */

}
