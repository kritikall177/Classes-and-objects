using System;

namespace Task2
{
    public abstract class Human
    {
        public string Name { get; protected set; }

        public string Surname { get; protected set; }

        public string Patronymic { get; protected set; }

        public DateTime Birthday { get; protected set; }

        protected Human()
        {
            Name = null;
            Surname = null;
            Patronymic = null;
            Birthday = new DateTime();
            Console.WriteLine("Empty human has been created");
        }

        protected Human(string name, string surname, string patronymic, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            Console.WriteLine($"{Name} has been created");
        }
        
        protected Human(Human person)
        {
            Name = person.Name;
            Surname = person.Surname;
            Patronymic = person.Patronymic;
            Birthday = person.Birthday;
            Console.WriteLine("human has been cloned");
        }

        ~Human()
        {
            Console.WriteLine($"Human {Name} has been deleted");
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Patronymic: {Patronymic}");
            Console.WriteLine($"Birthday: {Birthday.ToShortDateString()}");
        }

        public void PrintFullYears()
        {
            Console.WriteLine($"Full years: {(int)((DateTime.Today - Birthday).TotalDays / 365.2425)}");
        }

        protected string InputName()
        {
            Console.WriteLine("Write your name:");
            return Console.ReadLine();
        }
        
        protected string InputSurname()
        {
            Console.WriteLine("Write your surname:");
            return Console.ReadLine();
        }
        
        protected string InputPatronymic()
        {
            Console.WriteLine("Write your patronymic:");
            return Console.ReadLine();
        }
        
        protected DateTime InputDate()
        {
            Console.WriteLine("Write your Birthday:");
            var year = 0;
            var month = 0;
            var day = 0;
            while (day == 0 | year == 0 | month == 0)
            {
                Console.WriteLine("Year of birth:");
                year = Convert.ToInt32(Console.ReadLine());
                if (year >= DateTime.Today.Year)
                {
                    Console.WriteLine("Incorrect input");
                    year = 0;
                    continue;
                }
                
                Console.WriteLine("Month of birth:");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 12)
                {
                    Console.WriteLine("Incorrect input");
                    month = 0;
                    continue;
                }
                
                Console.WriteLine("Day of birth:");
                day = Convert.ToInt32(Console.ReadLine());
                if (day <= 31)
                {
                    continue;
                }

                Console.WriteLine("Incorrect input");
                day = 0;
            }
            return new DateTime(year, month, day);
        }

        public virtual void InputAdd()
        {
            Name = InputName();
            Surname = InputSurname();
            Patronymic = InputPatronymic();
            Birthday = InputDate();
        }

        public virtual void Edit()
        {
            Console.Clear();
            Print();
            Console.WriteLine("Edit name (1)");
            Console.WriteLine("Edit surname (2)");
            Console.WriteLine("Edit patronymic (3)");
            Console.WriteLine("Edit birthday (4)");
        }
    }
}