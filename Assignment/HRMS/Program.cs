using EmployeeLibb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    internal class Program
{
    static void Main(string[] args)
    {
            //Date date = new Date();
            //date.acceptDate();
            //date.PrintDate();
            //Date d1 = new Date(12, 2, 2002);
            //Date d2 = new Date(12, 2, 2005);
            //date.isValid(date);

            //Console.WriteLine("date"+(d1 - d2));

            Person person=new Person();
            person.Accept();
            person.Print();
            
            


    }
}
}
