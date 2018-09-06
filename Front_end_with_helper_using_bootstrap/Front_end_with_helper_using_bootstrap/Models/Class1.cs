using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Front_end_with_helper_using_bootstrap.Models
{
    public class Class1
    {

        public string title { get; set; }
        public string Description { get; set; }

         [DataType(DataType.Date)] 
        public DateTime? Enterdate { get; set; }
      
    }
}