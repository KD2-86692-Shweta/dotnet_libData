using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    internal class Person
    {
		private string name;
		private bool gender;
		private Date birth;
		private string address;

        public Person()
        {
				
        }

		public Person(string name,bool gender,Date birth,string address)
		{
			this.name = name;
			this.gender = gender;
			this.birth = birth;
			this.address = address;
		}
        public string Address
		{
			get { return address; }
			set { address = value; }
		}


		public Date Birth
		{
			get { return birth; }
			set { birth = value; }
		}


		public bool Gender
		{
			get { return gender; }
			set { gender = value; }
		}




		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int age
		{
            get { return Date.differenceofDates(birth, new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)); }
		}


		public void Accept()
		{
			Console.WriteLine("Enter name");
			name=Console.ReadLine();

			Console.WriteLine("Enter Gender");
			gender=Convert.ToBoolean(Console.ReadLine());

			Console.WriteLine("Enter Birth");
			Birth.acceptDate();

			Console.WriteLine("Enter Address");
			address=Console.ReadLine();
		}

		public void Print()
		{
			Console.WriteLine(name +" "+gender+ " "+birth+" "+address+" "+age);
		}

        public override string ToString()
        {
            return base.ToString();

        }
    }
}
