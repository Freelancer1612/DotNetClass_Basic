using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static DotNetClassDemo.LearningTopics;

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

            //int A = 0;
            //System.Type type = typeof(LearningTopics);

            List<string> lstData = new List<string>();
            for (byte i = 0; i < 100; i++)
            {
                lstData.Add(i.ToString());  /* 1 Ns x 100 */
            }

            /* Work One */
            Thread ObjWork = new Thread(DOSomeWork);
            InputParam ObjFirstWork = new InputParam();
            ObjFirstWork.StartCount = 0;
            ObjFirstWork.Limit = 50;
            ObjFirstWork.lstData = lstData;


            /* Work two */
            Thread ObjWork2 = new Thread(DOSomeWork);
            InputParam ObjFirstWork2 = new InputParam();
            ObjFirstWork2.StartCount = 50;
            ObjFirstWork2.Limit = 50;
            ObjFirstWork2.lstData = lstData;
           
            /* Execute the Print Work */
            ObjWork.Start(ObjFirstWork);
            ObjWork2.Start(ObjFirstWork2);
            ObjWork2.Suspend();





            //Task<Boolean> lstTask = new Task<bool>(DOSomeWork);
            //lstTask.Add

        }


        static void DOSomeWork(dynamic ObjInput)
        {
            for (byte i = ObjInput.StartCount; i < (ObjInput.StartCount + ObjInput.Limit); i++)
            {
                Console.WriteLine("Count " + i);
            }

            Thread.Sleep(5000);
            Console.WriteLine("Completed");

        }

        static async Task<Boolean> TaskFunction(dynamic ObjInput)
        {
            for (byte i = ObjInput.StartCount; i < (ObjInput.StartCount + ObjInput.Limit); i++)
            {
                Console.WriteLine("Count " + i);
            }

            Thread.Sleep(5000);
            Console.WriteLine("Completed");
            return await Task.FromResult(true);

        }

        public class InputParam
        {
           public byte StartCount { get; set; }
            public byte Limit { get; set; }
            public List<string> lstData { get; set; }

        }
        
    }
}