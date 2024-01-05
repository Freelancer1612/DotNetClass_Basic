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

            ////var Name =  String.Format("Hi {"+ (int)MailFields.Name + "}", "ARUN");

            //ARUN Obj = new ARUN();
            //Obj.Exec();


            //Console.WriteLine("Enter Your Date Of Birth");
            //String DateOfBirth = Console.ReadLine();
            //Console.WriteLine("Your Age Is : " + CalculateAge(DateOfBirth));

            String Output = Convert.ToString(null);
            String Input = null;
            String Ouput2 =  Input.ToString();


        }

        public static String CalculateAge(String DateOfBirth)
        {
            String Str_Message = "";
            try
            {
                DateTime dt_DOB = DateTime.Parse(DateOfBirth);
                int Age = DateTime.Now.Year - dt_DOB.Year;
                Str_Message =  Age.ToString();
            }
            catch (Exception ex)
            {
                Str_Message = ex.Message;
            }
            //finally
            //{

            //}
            return Str_Message;

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