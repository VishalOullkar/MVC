using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Templated_HTML_Helper.Models
{
    public class Class1
    {

        public int Id { get; set; }

        [Display(Name="Enter name")]
        public string Name { get; set; }

        public string Address { get; set; }
        public string city { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool IsEmp { get; set; }
    }
    public enum Gender { Male, Female }
}