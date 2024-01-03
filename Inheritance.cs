using System;

namespace DotNetClassDemo
{
    internal class Inheritance
    {
        public Inheritance()
        {

            /* What is Inheritance? */
            // Code reusability is one of the key features of OOPs, and it is achieved via inheritance.
            // Using inheritance, one or more classes can derive from an existing class.
            // The existing class is called a base class, and the inherited class is called a derived or inherited class.

            /* What are types Inheritance support in C# ? */
            // 1) Single inheritance
            // 2) Hierarchical inheritance
            // 3) Multilevel inheritance


            /* Bad Pactices */
            Student ObjStudent = new Student();
            ObjStudent.Login("Student", "123");

            Staff ObjStaff = new Staff();
            ObjStaff.Login("Staff", "123");

            Parent ObjParent = new Parent();
            ObjParent.Login("Parent", "123");


            /* Best Practices */
            StudentAccount ObjStudentAccount = new StudentAccount();
            ObjStudentAccount.Login("Student", "123");

            StaffAccount ObjStaffAccount = new StaffAccount();
            ObjStaffAccount.Login("Staff", "123");

            ParentAccount ObjParentAccount = new ParentAccount();
            ObjParentAccount.Login("Parent", "123");


            //EmployeeInformaion Obj = new EmployeeInformaion();

        }

    }

    /* ==== */
    /* Bad Pactices */
    #region"Bad Pactices"
    public class Student
    {
        public void Login(String UserName, String Password)
        {
            if (UserName == "Student" && Password == "123")
            {
                /* Dashboard */
                /* Fees Pending */
            }
        }
    }
    public class Staff
    {
        public void Login(String UserName, String Password)
        {
            if (UserName == "Staff" && Password == "123")
            {
                /* Dashboard */
                /* Student Details */
            }
        }
    }
    public class Parent
    {
        public void Login(String UserName, String Password)
        {
            if (UserName == "Parent" && Password == "123")
            {
                /* Dashboard */
                /* Child Pending Fees Details */
                /* Child Details */
            }
        }
    }
    #endregion
    /* ==== */

    /* ==== */
    /* Single Inheritance */
    #region"Single Inheritance"
    class BasicInformaion
    {
        public String Name { get; set; }
        public Boolean IsMale { get; set; }
        public String Address { get; set; }
        public String ContactNo { get; set; }

    }
    class EmployeeInformaion : BasicInformaion
    {
        public String Designation { get; set; }
        public DateTime DateOfJoin { get; set; }
        public Decimal Salary { get; set; }

    }
    #endregion
    /* ==== */

    /* ==== */
    /* Multi Level Inheritance */
    #region"Multi Level Inheritance"
    class Teacher : EmployeeInformaion
    {

    }
    /* ==== */
    #endregion

    /* ==== */
    /* Hierarchical Inheritance */
    #region "Hierarchical Inheritance"
    class UserAccount
    {
        public void Login(String UserName, String Password)
        {
            if (UserName == "Suport all Users" && Password == "123")
            {
                /* Dashboard */
                /* Fees Pending */
            }
        }
    }
    class StudentAccount : UserAccount
    {
        public int Add(int A, int B)
        {
            return A + B;
        }

        public int Add(int A, int B, int C)
        {
            return A + B;
        }

        public string Add(String A, String B)
        {
            return A + B;
        }

    }
    class StaffAccount : UserAccount
    {

    }
    class ParentAccount : UserAccount
    {

    }
    #endregion
    /* ==== */



}
