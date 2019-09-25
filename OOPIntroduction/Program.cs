using System;

namespace OOPIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee emp1 = new Employee();
            emp1.firstName = "Rohith";
            emp1.lastName = "Manthena";
            emp1.employer = "Tesla";
            emp1.setEmployeeId("1366188");
           

            emp1.EmployeeDetails();

            Person a = new Person();
            a.PersonLastName("Edison");

        }
    }
}
