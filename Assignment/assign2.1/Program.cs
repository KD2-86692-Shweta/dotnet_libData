using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.acceptDetails();

            string result=student.printData();
            Console.WriteLine(result);

           
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();

        }

        public struct Student 
        { 
            private string _name;
            private bool _gender;
            private int _age;
            private int _std;
            private char _div;
            private double _marks;

           
            public Student(string name,bool gender,int age,int std,char div,double marks)
            {
                _name = name;
                _gender = gender;
                _age = age;
                _std = std;
                _div = div;
                _marks = marks;
            }


            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

            public int Std
            {
                get { return _std; }
                set { _std = value; }
            }
 
            public char Div
            {
                get { return _div; }
                set { _div = value; }
            }
            public double Marks
            {
                get { return _marks; }
                set { _marks = value; }
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public bool Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }


            public void acceptDetails()
            {
                Console.WriteLine("Enter Name : ");
                _name=Console.ReadLine();

                Console.WriteLine("Enter gender: ");
               _gender = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter age");
                _age=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter std");
                _std= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter div");
                _div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Marks");
                _marks=Convert.ToDouble(Console.ReadLine());

                
            }

            public string printData()
            {
                
               return _name + " " + _gender.ToString()+" " +_age.ToString() + " " + _std.ToString() + _div.ToString() + " " + _marks.ToString();

            }
            }



        }

    }

