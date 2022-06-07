using System;

namespace Task2
{
    public class Employee : Human
    {
        protected string Organization { get; set; }
        protected int Salary { get; set; }
        protected byte Experience { get; set; }

        public Employee()
        {
            Organization = null;
            Salary = 0;
            Experience = 0;
            Console.WriteLine("Employee has been created");
        }

        public Employee(string name, string surname, string patronymic, DateTime birthday, string organization, int salary, byte experience) : base(name, surname, patronymic, birthday)
        {
            Organization = organization;
            Salary = salary;
            Experience = experience;
            Console.WriteLine("Employee has been created");
        }

        public Employee(Employee person) : base(person)
        {
            Organization = person.Organization;
            Salary = person.Salary;
            Experience = person.Experience;
            Console.WriteLine("Employee has been cloned");
        }

        ~Employee()
        {
            Console.WriteLine("Employee has been deleted");
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Organization: {Organization}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Experience: {Experience}");
        }

        protected string InputOrganization()
        {
            Console.WriteLine("Write your Organization:");
            return Console.ReadLine();
        }
        
        protected int InputSalary()
        {
            Console.WriteLine("Write your Salary:");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        protected byte InputExperience()
        {
            Console.WriteLine("Write your Experience:");
            return Convert.ToByte(Console.ReadLine());
        }
        
        public override void InputAdd()
        {
            base.InputAdd();
            Organization = InputOrganization();
            Salary = InputSalary();
            Experience = Experience;
        }

        public override void Edit()
        {
            while (true)
            {
                base.Edit();
                Console.WriteLine("Edit Organization (5)");
                Console.WriteLine("Edit Salary (6)");
                Console.WriteLine("Edit Experience (7)");
                if (GetType().Name == "Driver")
                {
                    return;
                }
                
                Console.WriteLine("Exit (e)");
                switch (Console.ReadLine())
                {
                    case "1":
                        Name = InputName();
                        break;

                    case "2":
                        Surname = InputSurname();
                        break; 

                    case "3":
                        Patronymic = InputPatronymic();
                        break;
                    
                    case "4":
                        Birthday = InputDate();
                        break;
                    
                    case "5":
                        Organization = InputOrganization();
                        break;
                    
                    case "6":
                        Salary = InputSalary();
                        break;
                    
                    case "7":
                        Experience = InputExperience();
                        break;
                    
                    case "e":
                        return;
                }
            }
        }
    }
}