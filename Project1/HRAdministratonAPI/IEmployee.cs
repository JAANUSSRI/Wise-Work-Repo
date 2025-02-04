using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdministratonAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FName { get; set; }
        string LName { get; set; }
        decimal Salary { get; set; }
        
    }
}