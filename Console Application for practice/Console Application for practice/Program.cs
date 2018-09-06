using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_Application_for_practice
{
   

    public class myclass
    {
       public string fname, lname;
        public myclass(string myfname, string mylname)
        {
            fname = myfname;
            lname = mylname;
        }

        public myclass(myclass oo)
        {
            fname = oo.fname;
            lname = oo.lname;
        }
    }

    public class Program
    {
        public static void Main()
        {
            myclass obj = new myclass("Vishal", "Oulkar");
            myclass obj1 = new myclass(obj);
            Console.WriteLine(obj1.fname, obj1.lname);

            Console.ReadLine();


        }


    }

  
}
