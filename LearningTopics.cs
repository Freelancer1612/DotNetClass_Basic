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


        public void MemoryAddress()
        {

            byte x = 100;
            byte y = 200;



        }
    }
}