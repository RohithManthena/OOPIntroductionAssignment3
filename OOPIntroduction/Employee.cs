using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntroduction
{
    class Employee : Person
    {
        public string EmployeeId;
        public string employer;
        
        public void EmployeeDetails()
        {
            Console.WriteLine(firstName+ " " +lastName+ " is an employee of "+employer+" with employee id "+EmployeeId);
        }

        public void setEmployeeId(String EmployeeId)
        {
            this.EmployeeId = EmployeeId;
        }
 

        

    }
}
