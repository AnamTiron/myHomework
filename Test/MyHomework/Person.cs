using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyHomework
{
    public abstract class Person
    {

        protected static string lastName;
        protected static string firstName;
        protected string dateOfBirth;



    }

    public class Employee : Person
    {
        protected string dateOfEmployment;
        protected int salary;
        protected int availableDaysOff;

        public Employee()
        {
            Console.WriteLine("Last Name:");
            lastName = Console.ReadLine();
            Console.WriteLine("First Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Date Of Birth:");
            dateOfBirth = Console.ReadLine();
            Console.WriteLine("Date of Employment:");
            dateOfEmployment = Console.ReadLine();
            Console.WriteLine("Salary:");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Available Days Off:");
            availableDaysOff = Convert.ToInt32(Console.ReadLine());

        }
        public Employee(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;

        }

        public void displayInfo()
        {
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Salary: {0}", salary);
            Console.WriteLine("Available Days Off: {0}", availableDaysOff);


        }
        private int SubstractDays(int duration)
        {
            availableDaysOff -= duration;
            return availableDaysOff;
        }
        public void addNewLeave()
        {

           
            Leave leave = new Leave();

            if (Leave.duration >= availableDaysOff)
            {

                throw new NegativeLeaveDays("you don't have that many leave days");
            }
            else
            {
                SubstractDays(Leave.duration);
                Leave.employee = new Employee(firstName, lastName); //setez employee de pe leave cu nume si prenume
            }
        }
    }

        public class Leave
        {
            public string startingDate;
            public static int duration;
            /*   public enum leaveType {
                   medical,
                   holiday,
                   other
               };
               */
            public string leaveType;
            public static Employee employee;


        public Leave()
        {

            Console.WriteLine("starting date:");
            startingDate = Console.ReadLine();
            Console.WriteLine("duration:");
            duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("leave type (medical/holiday/other):");
            leaveType = Console.ReadLine();
        }

        }

        [Serializable]
        public class NegativeLeaveDays : Exception
        {
            public NegativeLeaveDays()
            {
            }
            
             public NegativeLeaveDays(string message)
                : base(message)
            {
            }
            public NegativeLeaveDays(string message, System.Exception innerException)
        : base(message, innerException)
            {
            }
        }


    }


