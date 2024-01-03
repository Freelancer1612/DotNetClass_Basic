using System;

namespace DotNetClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* C# Learning Topics */
            //LearningTopics ObjLearning = new LearningTopics();

            /* Object-Oriented Programming */
            //Inheritance ObjInheritance = new Inheritance();
            //Polymorphism ObjPolymorphism = new Polymorphism();
            //Encapsulation ObjEncapsulation = new Encapsulation();
            //Abstraction ObjAbstraction = new Abstraction();

            decimal TotalAmount = CalculateSaleAmount(2, 10);

        }

        static decimal CalculateSaleAmount(int Qty, Decimal Rate, decimal Discount = 0)
        {
            return Qty * Rate - Discount;
        }

    }
}