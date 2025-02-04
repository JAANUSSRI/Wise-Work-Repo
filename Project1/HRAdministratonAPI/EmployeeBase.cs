using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdministratonAPI
{
    public class EmployeeBase: IEmployee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public virtual decimal Salary { get; set; }
        
    }
}