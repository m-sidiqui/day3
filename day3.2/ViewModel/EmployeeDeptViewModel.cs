using day3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace day3._2.ViewModel
{
    public class EmployeeDeptViewModel
    {
        Employee myVar=new Employee();

        public string firstName
        {
            get { return myVar.firstName; }
            set { myVar.firstName = value; }
        }

        
        public string lastName
        {
            get { return myVar.lastName; }
            set { myVar.lastName = value; }
        }

        Department myVar1= new Department();

        public int deptId
        {
            get { return myVar1.deptId; }
            set { myVar1.deptId = value; }
        }

        
        public string deptName
        {
            get { return myVar1.deptName; }
            set { myVar1.deptName = value; }
        }



    }
}