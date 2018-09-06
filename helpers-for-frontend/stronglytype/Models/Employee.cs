using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stronglytype.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public int Name { get; set; }
        public string address { get; set; }

        public bool IsEmp { get; set; }

        
    }
    public enum Gender { Male,Female}
}