using System;

namespace Task2
{
    public class Student : Human
    {
        private string Faculty { get; set; }
        private byte Year { get; set; }
        private string Group { get; set; }

        public Student()
        {
            Faculty = null;
            Year = 0;
            Group = null;
            Console.WriteLine("Student has been created");
        }

        public Student(string name, string surname, string patronymic, DateTime birthday, string faculty, byte year, string group) : base(name, surname, patronymic, birthday)
        {
            Faculty = faculty;
            Year = 0;
            Group = group;
            Console.WriteLine("Student has been created");
        }

        public Student(Student person) : base(person)
        {
            Faculty = person.Faculty;
            Year = person.Year;
            Group = person.Group;
            Console.WriteLine("Student has been cloned");
        }
        
        ~Student()
        {
            Console.WriteLine("Student has been deleted");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Group: {Group}");
        }

        private string InputFaculty()
        {
            Console.WriteLine("Write your faculty:");
            return Console.ReadLine();
        }

        private byte InputYear()
        {
            while (true)
            {
                Console.WriteLine("Write your year:");
                var year = Convert.ToByte(Console.ReadLine());
                if(year < 1 | year >= 6)
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    return year;
                }
            }
        }

        private string InputGroup()
        {
            Console.WriteLine("Write your group:");
            return Console.ReadLine();
        }
        
        public override void InputAdd()
        {
            base.InputAdd();
            Faculty = InputFaculty();
            Year = InputYear();
            Group = InputGroup();
        }

        public override void Edit()
        {
            while (true)
            {
                base.Edit();
                Console.WriteLine("Edit Faculty (5)");
                Console.WriteLine("Edit Year (6)");
                Console.WriteLine("Edit Group (7)");
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
                        Faculty = InputFaculty();
                        break;
                    
                    case "6":
                        Year = InputYear();
                        break;
                    
                    case "7":
                        Group = InputGroup();
                        break;
                    
                    case "e":
                        return;
                }
            }
        }
    }
}