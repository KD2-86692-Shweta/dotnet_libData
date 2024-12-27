using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assign2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students;

            createArray(ref students);
            acceptInfo(students);
            printInfo(students);

            Student[] reversedStudents = revArray(students);
            Console.WriteLine("Reversed Student Information:");
            printInfo(reversedStudents);

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();


        }

        public static void createArray(ref Student[] student)
        {

            Console.WriteLine("Enter the number of Students");
            int size = Convert.ToInt32(Console.ReadLine());
            student = new Student[size];
        }

        public static void acceptInfo(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();


                Console.WriteLine("Enter id of Student : ");
                student[i].Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter name of Student : ");
                student[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Standard of Student : ");
                student[i].Std = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Age of Student : ");
                student[i].Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Marks of Student : ");
                student[i].Marks = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static void printInfo(Student[] student)
        {

            foreach (var item in student)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Std + " " + item.Age + " " + item.Marks);
            }

        }


        public static Student[] revArray(Student[] student)
        {
            Student[] reversedArray = new Student[student.Length];
            for (int i = 0; i < student.Length; i++)
            {
                reversedArray[i] = student[student.Length - 1 - i]; 
            }
            return reversedArray; 
        }

    }
    public class Student
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int std;

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int marks;

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public Student()
        {

        }
        public Student(int id, string name, int std, int age, int marks)
        {
            this.id = id;
            this.name = name;
            this.std = std;
            this.age = age;
            this.marks = marks;
        }

    }

