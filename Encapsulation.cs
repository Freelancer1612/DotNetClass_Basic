using System;

namespace DotNetClassDemo
{
    internal class Encapsulation
    {
        public Encapsulation()
        {

            /* What is Encapsulation? */
            /* Encapsulation is a way to restrict the direct access to some components of an object,
             * so users cannot access state values for all of the variables of a particular object.
             * Encapsulation can be used to hide both data members and data functions or methods associated with an instantiated class or object.
             */

            /* Why do we need encapsulation? */
            /* Encapsulation is an important concept in object-oriented programming (OOP) because it allows you to hide the internal details (implementation) of an object from other objects and the outside world. This provides a number of benefits,
             * such as:
                1) Abstraction: Encapsulation allows you to create a level of abstraction between the internal workings of an object and its external behavior. This makes it easier to understand the code and reduces the risk of errors caused by changing the internal data directly.
                2) Modularity: Encapsulation allows you to create self-contained objects that can be reused and combined in different ways. This makes your code more modular and easier to maintain.
                3) Security: Encapsulation allows you to control access to the internal data of an object, which can improve the security of the system by preventing unauthorized access or modification of sensitive data.
                4) Flexibility: Encapsulation allows you to change the internal implementation of an object without affecting the rest of the system. This makes your code more flexible and adaptable to changing requirements.
                5) Extensibility: Encapsulation allows you to create a stable and robust system, as it allows you to add new features and functionality to the objects without affecting the existing code.
            */

            /* Encapsulation is achieved through the use of access modifiers */
            // 1) "public" members of a class can accessed with anywhere.
            // 2) "private" members of a class can only be accessed within the class itself.
            // 3) "protected" members can be accessed within the class and any derived classes.
            // 4) "internal" members can be accessed within the same assembly.

            /* Example of Encapsulation */

        }
    }

    /* ===== */
    /* Access Modifiers */
    #region "Access Modifiers"
    public class AccessModifiers
    {
        public int Addition(int A, int B)
        {
            /* It is a Known Concept So We Don't Need to Secure */
            return A + B;
        }

        internal decimal TaxCalulation(decimal TotalAmount)
        {
            /* All Company has own Tax percentage based on Company Product sales */
            return CalculateTax(TotalAmount);
        }

        private decimal CalculateTax(decimal TotalAmount)
        {
            /* It a Child Function TaxCalculation So we don't need share to another class */
            return (TotalAmount / 100) * 10;
        }

        protected Decimal GetCurrentGSTPercentage()
        {
            /* We Can use this Percentage in our attached Class */
            return 12;
        }

    }
    #endregion
    /* ===== */

}
