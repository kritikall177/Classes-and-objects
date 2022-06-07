using System;

namespace Task2
{
    public sealed class Driver : Employee
    {
        private string CarBrand { get; set; }
        private string CarModel { get; set; }

        public Driver()
        {
            CarBrand = null;
            CarModel = null;
            Console.WriteLine("Driver has been created");
        }

        public Driver(string name, string surname, string patronymic, DateTime birthday, string organization, int salary, byte experience, string carBrand, string carModel) : base(name, surname, patronymic, birthday, organization, salary, experience)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            Console.WriteLine("Driver has been created");
        }

        public Driver(Driver person) : base(person)
        {
            CarBrand = person.CarBrand;
            CarModel = person.CarModel;
            Console.WriteLine("Driver has been cloned");
        }

        ~Driver()
        {
            Console.WriteLine("Driver has been deleted");
        }
        
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Car Brand: {CarBrand}");
            Console.WriteLine($"Car Model: {CarModel}");
        }

        private string InputCarBrand()
        {
            Console.WriteLine("Write your Car Brand:");
            return Console.ReadLine();
        }

        private string InputCarModel()
        {
            Console.WriteLine("Write your Car Model:");
            return Console.ReadLine();
        }
        
        public override void InputAdd()
        {
            base.InputAdd();
            CarBrand = InputCarBrand();
            CarModel = InputCarModel();
        }

        public override void Edit()
        {
            while (true)
            {
                base.Edit();
                Console.WriteLine("Edit Car Brand (8)");
                Console.WriteLine("Edit Car Model (9)");
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
                    
                    case "8":
                        CarBrand = InputCarBrand();
                        break;
                    
                    case "9":
                        CarModel = InputCarModel();
                        break;
                    
                    case "e":
                        return;
                }
            }
        }
    }
}