using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System;

namespace DotNetClassDemo
{
    internal class LearningTopics
    {
        public LearningTopics()
        {
            /* Learn the Datatypes With Default Values */
            LearnDataTypes();

            /* Learn the Datatypes Handling Memory */
            LearnDataPart();

            /* Learn the Variable With Rules */
            LearnVariables();

            /* Learn the Type Conversions */
            LearnTypeConversions();

            /* Learn the Boxing and Unboxing */
            LeanBoxingUnboxing();

            /* Learn the Enum */
            LearnEnums();

            /* Learn Partial Class */
            LearnPartialClass();

            /* Learn the Partial Method */
            LearnPartialMethod();

            /* Learn the Learn Exception Handling */
            LearnExceptionHandling();

            /* Learn the Difference between Convert.ToString() and ToString() */
            LearnStringConvertDiff();


        }

        /* ===== */
            /* Learn the Datatypes With Default Values */
            #region "Data types"
            public void LearnDataTypes()
        {
            /* Learn the Primitive Datatypes With Default Values */
            PrimitiveDatatypes();

            /* Learn the Non-Primitive Datatypes With Default Values */
            NonPrimitiveDatatypes();

        }
        private void PrimitiveDatatypes()
        {
            /* C# Primitive Data Types */
            /* Primitive data types are further divided as,
                1) byte
                2) short
                3) int
                4) float
                5) double
                6) long
                7) char
                8) bool
                9) datetime
                10) string
                11) object
            */

            /* Sample Examples */

            /* 1) Boolean */
            #region"Boolean"
            bool IsCorrect = true;
            /* Default value: false */
            #endregion

            /* 2) Signed Integral */
            #region"Signed Integral"
            sbyte level = 23;
            /* Range: -128 to 127 */
            /* Default value: 0 */

            /*  Short */
            short value = -1109;
            /* Range: -32,768 to 32,767 */
            /* Default value: 0 */

            /*  int */
            int score = 51092;
            /* Range: -2,147,483,648 to 2,147,483,647 */
            /* Default value: 0 */

            /* long */
            long range = -7091821871L;
            /* Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 */
            /* Default value: 0 */
            #endregion

            /* 3) Unsigned Integral */
            #region "Unsigned Integral"
            /* Byte */
            byte age = 62;
            /* Range:  0 to 255. */
            /* Default value: 0 */

            /* Ushort */
            ushort value2 = 42019;
            /* Range:  0 to 65,535. */
            /* Default value: 0 */

            /* uint */
            uint totalScore = 1151092;
            /* Range:  0 to 4,294,967,295. */
            /* Default value: 0 */

            /* ulong */
            ulong range2 = 17091821871L;
            /* Range:  0 to 18,446,744,073,709,551,615 */
            /* Default value: 0 */

            #endregion

        }
        private void NonPrimitiveDatatypes()
        {
            /* C# Non-Primitive Data Types */
            /* Non-primitive data types are further divided as,
             * class
               struct
               enum
               interface
               delegate
               array
            */

            /* Example */

            /* Array */
            #region"Array"
            /* Arrays are used to store multiple values in a single variable */

            /* ===== Type Of Array ===== */
            // 1) Single Dimensional Arrays
            // 2) Multidimensional Arrays
            // 3) Jagged Arrays


            /*  Single Dimensional Arrays */
            #region"Single Dimensional Arrays"
            /* only one column for storing the values */
            int[] Age = { 10, 15, 13, 9, 21 };

            /* Read By Index Value */
            int Result = Age[0]; /* Output : 10 */
            #endregion


            /*  Multidimensional Arrays */
            #region"Multidimensional Arrays"
            /* The multidimensional array has multiple rows and multiple columns for storing values */
            int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            /* Read By Index Value */
            int FirstRow_FirstCol = array[0, 0]; /* Output : 1 */
            #endregion

            /*  Jagged Arrays */
            #region"Jagged Arrays"
            /* A jagged array in C# is called an "array of arrays" */
            int[][] jaggedArray = new int[3][];

            // Initializing subarrays with different lengths
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6, 7 };
            jaggedArray[2] = new int[] { 8, 9 };

            /* Read By Index Value */
            int SecondRow_FirstCol = jaggedArray[1][0];  /* Output : 4 */
            #endregion

            #endregion

            /* String */
            #region"String"
            /* The string is an object of the String class that represents a sequence of characters.
             * We can perform many operations on strings such as concatenation, comparison, getting substring, search, trim, replacement, etc.
             * */
            string Str_Name = "DotNet"; /* Creates one object of string and assig the value "DotNet" */
            Str_Name = "Class"; /* Creates a fresh object and assign the value "Class" */
            #endregion

        }
        #endregion
        /* ===== */

        /* ===== */
        /* Learn the Datatype Parts */
        #region"Datatype Parts"
        public void LearnDataPart()
        {
            /* In .NET Microsoft has divided data types in two parts, 
             * 1) Value Type (Fixed in size)
             * 2) Reference Type (Not fixed in size)
            */

            LearnValueType();
            LearnReferenceType();
        }

        private void LearnValueType()
        {
            /* 
             * Value types are fixed in size.
               Value types are made in system stack.
               Actual values of data are stored in stack.
               If you assign a value of a variable to another it will create two copies.
            */

            /* Example */
            // All primitive data type except string and object are example of value types. 
            int A = 0;
        }
        private void LearnReferenceType()
        {
            /* 
             *  Reference types are not fixed in size.
                They are maintained in system managed heap but it also uses stack to store reference of heap.
                Two primitive types (string and object) and non-primitive data types (class, interface & delegate) are examples of reference type..
            */

            /* Example */
            // CLR manages heap (large memory area). Heap address is accessed from stack.
            // In reference type reference is used for processing using both managed heap and stack (operational entity). 
            LearningTopics ObjTopics = new LearningTopics();
        }

        #endregion
        /* ===== */

        /* ===== */
        /* Learn the Variable With Rules */
        #region"Variables"
        public void LearnVariables()
        {
            /* How to declare variables */
            /* Syntax : [Datatype] VariableName */
            byte Age;

            /* Declared and initialized */
            bool IsMale = true;

            /* Rules for Naming Variables in C# 
               1) Valid Characters:
                    Variable names can consist of letters (both uppercase and lowercase), digits, and underscores.
                    The first character of a variable name cannot be a digit.
               2) Case Sensitivity:
                    Most programming languages are case-sensitive. This means that myVariable and MyVariable would be treated as different variables.
               3) Reserved Keywords:
                    Avoid using reserved keywords that have special meanings in the programming language. For example, in C#, you cannot use keywords like int, if, else, etc., as variable names.
          
             Best Practices for Naming a Variable
               1) Choose a variable name that make sense. For example, name, age, subject makes more sense than n, a and s.
               2) Use camelCase notation (starts with lowercase letter) for naming local variables. For example, numberOfStudents, age, etc.
               3) Use PascalCase or CamelCase (starts with uppercase letter) for naming public member variables. For example, FirstName, Price, etc.
               4) Use a leading underscore (_) followed by camelCase notation for naming private member variables. For example, _bankBalance, _emailAddress, etc.
             */
        }
        #endregion
        /* ===== */

        /* ===== */
        /* Learn the Type Conversions */
        #region"Type Conversions"
        public void LearnTypeConversions()
        {
            /* Conversion is based on type compatibility and data compatibility */
            /* There are two types of conversions: 
                    1) Implicit Conversion
                    2) Explicit Conversion
            */

            LearnImplicitConversion();
            LearnExplicitConversion();


            /* ==== */
            /* Microsoft .NET provides three ways of type conversion */
            /* Parsing */
            int ParseValue = int.Parse("45");

            /* Exception Handled Parsing */
            int Outputvalue = 0;
            int.TryParse("ONE", out Outputvalue);
            /* ==== */

        }
        private void LearnImplicitConversion()
        {
            // Implicit conversion from int to double
            int integerValue = 42;
            double doubleValue = integerValue; // Implicit conversion

            /* This is possible because converting from an int to a double doesn't result in a loss of information;
             * all integer values can be represented precisely as double values.
             */
        }
        private void LearnExplicitConversion()
        {
            // Implicit conversion from int to double
            double doubleValue = 42.56;
            int integerValue = (int)doubleValue; // Implicit conversion

            /* This is possible because converting from an double to a int result in a loss of information;
             * all integer values can be represented precisely as double values.
             */
        }
        #endregion
        /* ===== */

        /* ===== */
        /* Learn the Boxing and unboxing */
        #region "Boxing and Unboxing"
        public void LeanBoxingUnboxing()
        {
            /* Boxing and unboxing is an important concept in C# type system.
             * With Boxing and unboxing one can link between value-types and reference-types by allowing any value of a value-type to be converted to and
             * from type object.*/

            LearnBoxing();
            LearnUnBoxing();
        }

        private void LearnBoxing()
        {
            /* Boxing  
               1) Boxing is a mechanism in which value type is converted into reference type.
               2) It is implicit conversion process in which object type (super type) is used.
               3) In this process type and value both are stored in object type */
            /* Example */
            int i = 10;
            object o = i;             // boxing  
        }
        private void LearnUnBoxing()
        {
            /* Unboxing  
               1) Unboxing is a mechanism in which reference type is converted into value.
               2) It is explicit conversion process.

            /* Example */
            int i = 10;
            object o = i;            // boxing  
            int j = (int)o;          // unboxing  
        }
        #endregion
        /* ===== */

        /* ===== */
        /* Enums */
        #region "Enums"
        public enum FeesSMSFields
        {
            SenderName = 0,
            ReceiverName = 1,
            FeesAmount = 2
        }
        public void LearnEnums()
        {
            /* What Is Enums? */
            /* An enum type is a distinct value type that declares a set of named constants. */
            /* Example */

            /* Orginal Message */
            //string Str_Message = "Hi Ravi, We have received your payment(500.00)." +
            //                     " Thanks for paying so promptly." +
            //                     " If you have any query please contact Arun";


            /* Bad practice */
            string Str_BadPractice_Message = "Hi {1}, We have received your payment({2})." +
                                 " Thanks for paying so promptly." +
                                 " If you have any query please contact {0}";
            Str_BadPractice_Message = string.Format(Str_BadPractice_Message, "Arun", "Ravi", "500.00");


            /* Best practice */
            string Str_BestPractice_Message = "Hi {" + (int)FeesSMSFields.ReceiverName + "}, We have received your payment({" + (int)FeesSMSFields.FeesAmount + "})." +
                                 " Thanks for paying so promptly." +
                                 " If you have any query please contact {" + (int)FeesSMSFields.SenderName + "}";
            Str_BestPractice_Message = string.Format(Str_BestPractice_Message, "Arun", "Ravi", "500.00");

        }
        #endregion
        /* ===== */

        /* ===== */
        /* Partial Class */
        #region"Partial Class"
        public partial class BankAccount
        {
            public string AccountNumber { get; set; }
            public string AccountName { get; set; }
            public string AccountType { get; set; }
        }
        public partial class BankAccount
        {
            public string BankName { get; set; }
            public string Branch { get; set; }
            public string IFSC { get; set; }
        }
        public void LearnPartialClass()
        {
            /* What is Partial Class and Use ? */
            /* It is possible to split the definition of a class, a struct, an interface or a method over two or more source files.
             * Each source file contains a section of the type or method definition, and all parts are combined when the application is compiled.
             * */


            /* Example */

            /* Create New Object For Bank Account */
            BankAccount ObjTransfer = new BankAccount();

            /* First Part */
            ObjTransfer.AccountNumber = "IOB0000001";
            ObjTransfer.AccountName = "ARUN";
            ObjTransfer.AccountType = "Savings";

            /* Second Part */
            ObjTransfer.BankName = "IOB";
            ObjTransfer.Branch = "Coimbatore";
            ObjTransfer.IFSC = "IOB4589";

        }
        #endregion
        /* ===== */

        /* ===== */
        /* Partial Method */
        #region"Partial Method"
        public partial class Sales
        {
            partial void SendSMS(string ContactNo);
            public void ProductSale(string ContactNo, string ProductCode, byte Qty, decimal Rate, decimal Amount)
            {
                /* =========== */
                /* Store the Sales Details to Data Source */
                /* **************************************** */
                /* =========== */

                /* Send Thank You Message to Client */
                SendSMS(ContactNo);
            }

            /* Now Developer Can Stop this service anytime, System Never rise any errors */
            partial void SendSMS(string ContactNo)
            {
                // SMS Sending Code //
            }

        }
        public void LearnPartialMethod()
        {
            /* What is Partial Method? */
            /* A partial method has its signature defined in one part of a partial type, and its implementation defined in another part of the type.Partial methods enable class designers to provide method hooks, similar to event handlers, that developers may decide to implement or not. If the developer does not supply an implementation, the compiler removes the signature at compile time.
             * The following conditions apply to partial methods:
             *  1) Declarations must begin with the contextual keyword partial.
             *  2) Signatures in both parts of the partial type must match.
                The partial keyword isn't allowed on constructors, finalizers, overloaded operators,
             */

            /* Exampe */
            Sales ObjSales = new Sales();
            ObjSales.ProductSale("9095352489", "Item0001", 5, 10, 50);
        }
        #endregion
        /* ===== */

        /* ===== */
        /* Exception Handling */
        #region "Exception Handling"
        public void LearnExceptionHandling()
        {
            /* What Is Exception Handling? */
            /* Exception Handling in C# is a process to handle runtime errors.
             * We perform exception handling so that normal flow of the application can be maintained even after runtime errors.
             * In C#, exception is an event or object which is thrown at runtime. All exceptions the derived from System.Exception class. It is a runtime error which can be handled. 
             * If we don't handle the exception, it prints exception message and terminates the program.
             */

            // C# Exception Classes
            // All the exception classes in C# are derived from System.Exception class.
            // Let's see the list of C# common exception classes.
            /* 
             * System.DivideByZeroException => handles the error generated by dividing a number with zero.
             * System.NullReferenceException => handles the error generated by referencing the null object.
             * System.InvalidCastException => handles the error generated by invalid typecasting.
             * System.IO.IOException  => handles the Input Output errors.
             * System.FieldAccessException => handles the error generated by invalid private or protected field access.
             */

            /* C# Exception Handling Keywords */
            /*
             * i)   try       => The try block in C# is used to place the code that may throw exception.
             * ii)  catch     => The catch block is used to handled the exception. The catch block must be preceded by try block.
             * iii) finally   => The finally block is used to execute important code which is to be executed whether exception is handled or not. It must be preceded by catch or try block.
             */

            /* Example For Try, Catch */
            String Str_WrongDate = "45-JAN-2024"; /* It's a Wrong Date */
            String ReturnMessage = ConvetStringToDate(Str_WrongDate);

            /* Example For Try, Catch, finally */
            int ErrorCase = DivideByTwo("0"); /* Output 0 */
            int ValidCase = DivideByTwo("10"); /* Output 5 */

        }
        public string ConvetStringToDate(String CurentDate)
        {
            String Message = "";
            DateTime dt_Output = new DateTime();

            try
            {
                dt_Output = DateTime.Parse(CurentDate);
                Message = "Date has been Converted Successfully";
            }
            catch(Exception ex) 
            {
                Message = "Sorry, Given Date Is Invalid(" + CurentDate + "), Please Check and Contine";
            }
            return Message;
        }
        public int DivideByTwo(String InputValue)
        {
            string Str_Message = "";
            int t_ReturnValue = 0;

            try
            {
                int number = int.Parse(InputValue);
                t_ReturnValue = 2 / number; // Potential DivideByZeroException
                Str_Message = "Success";
            }
            catch (FormatException ex)
            {
                Str_Message = "Error: Input is not a valid number.";
            }
            catch (DivideByZeroException ex)
            {
                Str_Message = "Error: Cannot divide by zero.";
            }
            catch (Exception ex)
            {
                Str_Message = "An unexpected error occurred.";
            }
            finally
            {
                /* If System rise an error we assign default Value */
                if (Str_Message != "Success")
                {
                    t_ReturnValue = -1;
                }
            }
            return t_ReturnValue;
        }
        #endregion
        /* ===== */

        /* ===== */
        /* Learn the Difference between Convert.ToString() and ToString() */
        #region"Learn String ConvertDiff"
        public void LearnStringConvertDiff()
        {
            /* In C#, Convert.ToString() and ToString() are two different methods used for converting values to string representations, 
             * but they are used in different contexts.
             */

            /* Convert.ToString() Method:
                This method is part of the Convert class in the System namespace.
                It is a static method that can be called directly on the Convert class without having an instance of an object.
                It is designed to handle a wide variety of data types and provides a consistent way to convert various types to their string representations.
                If the input value is null, it returns an empty string instead of throwing a NullReferenceException.
            */
            int number = 42;
            string strNumber = Convert.ToString(number);

            /* ToString() Method:
                This method is part of the Object class, the base class for all types in C#.
                It is an instance method, which means it needs to be called on an object.
                Every type in C# inherits from Object, and therefore, every object in C# has a ToString() method.
                The implementation of ToString() can vary between different types and is often overridden in derived classes to provide a meaningful string representation.
            */
            DateTime currentDate = DateTime.Now;
            string strDate = currentDate.ToString();
        }
        #endregion
        /* ===== */

            public void MemoryAddress()
        {

            byte x = 100;
            byte y = 200;



        }
    }
}