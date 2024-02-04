using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DotNetClassDemo.LearningTopics;

namespace DotNetClassDemo
{
    internal class Program
    {
        private static readonly object Name;

        static async Task Main(string[] args)
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

            //List<string> lstData = new List<string>();
            //for (byte i = 0; i < 100; i++)
            //{
            //    lstData.Add(i.ToString());  /* 1 Ns x 100 */
            //}

            ///* Work One */
            //Thread ObjWork = new Thread(DOSomeWork);
            //InputParam ObjFirstWork = new InputParam();
            //ObjFirstWork.StartCount = 0;
            //ObjFirstWork.Limit = 50;
            //ObjFirstWork.lstData = lstData;


            ///* Work two */
            //Thread ObjWork2 = new Thread(DOSomeWork);
            //InputParam ObjFirstWork2 = new InputParam();
            //ObjFirstWork2.StartCount = 50;
            //ObjFirstWork2.Limit = 50;
            //ObjFirstWork2.lstData = lstData;

            ///* Execute the Print Work */
            //ObjWork.Start(ObjFirstWork);
            //ObjWork2.Start(ObjFirstWork2);
            //ObjWork2.Suspend();


            //int result = await PerformAsyncOperation();
            //if(result == 0)
            //{
            //    Console.Write("Invalid");


            //}


            String[] LstName = { "ARUN", "Raj", "Aswin", "Boomi" };
            var TaskJobs = new Task[LstName.Length];
            for (byte i = 0; i< LstName.Length; i++)
            {
                TaskJobs[i] = SendSMS(LstName[i]);
            }
            Console.WriteLine("Waiting Start " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));

            Task.WaitAll(TaskJobs.ToArray());

            Console.WriteLine("Waiting End " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));

            for (int i = 0; i < TaskJobs.Length; i++)
            {

                Console.WriteLine("Checking Time " + "" + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));

                if (TaskJobs[i].IsCompleted)
                {
                    Console.WriteLine("Task  " + i + "Completed"  +" " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));
                }
            }

        }

        public static async Task<Boolean> SendSMS(String Name)
        {
            Console.WriteLine("Sending To ..." + Name + "" + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));
            await Task.Delay(3000); // Simulating a 3-second delay
            Console.WriteLine("Sent Successfully To " + "" + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss"));
            return true;
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