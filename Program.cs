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

           var Name =  String.Format("Hi {"+ (int)MailFields.Name + "}", "ARUN");

            ARUN Obj = new ARUN();
            Obj.Exec();

        }

        public enum MailFields
        {
            Name = 0,
            FeesAmount = 1,
           

        }


        public partial class ARUN
        {
            partial void Test();

            public void Exec()
            {
                Test();
            }

        }

        public partial class ARUN
        {
            partial void Test()
            {

            }

        }


    }
}