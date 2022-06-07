using System;
using System.Collections.Generic;

namespace Task2
{
    internal partial class Program
    {
        public static void PrintMainInfoList()
        {
            for (var i = 0; i < _list.Count; i++)
            {
                var person = _list[i];
                var a = person.GetType();
                Console.WriteLine($"{person.Name} {person.GetType().Name} ({i})");
            }
            
            Console.WriteLine("Leave (-1)");
        }
        public static void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("Who do you want to add?");
            Console.WriteLine("Student (1)");
            Console.WriteLine("Employee (2)");
            Console.WriteLine("Driver (3)");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        var person = new Student();
                        person.InputAdd();
                        Program._list.Add(person);
                        return;

                    case "2":
                        var person1 = new Employee();
                        person1.InputAdd();
                        Program._list.Add(person1);
                        return;

                    case "3":
                        var person2 = new Driver();
                        person2.InputAdd();
                        Program._list.Add(person2);
                        return;
                }
            }
        }
        
        public static void EditPerson()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Who do you want to Edit?");
                PrintMainInfoList();
                var menu = Convert.ToInt32(Console.ReadLine());
                if (menu <= _list.Count & menu >= 0)
                {
                    var person = _list[menu];
                    person.Edit();
                    _list[menu] = person;
                }
                
                if (menu == -1)
                {
                    return; 
                }
            }
        }

        public static void DeletePerson()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Who do you want to Delete?");
                PrintMainInfoList();
                var menu = Convert.ToInt32(Console.ReadLine());
                if (menu <= _list.Count & menu >= 0)
                {
                    _list.RemoveAt(menu);
                }
                
                if (menu == -1)
                {
                    return;
                }
            }
        }

        public static void ShowDetailPerson()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Who do you want to see?");
                PrintMainInfoList();
                var menu = Convert.ToInt32(Console.ReadLine());
                if (menu <= _list.Count & menu >= 0)
                {
                    Console.Clear();
                    _list[menu].Print();
                    _list[menu].PrintFullYears();
                    Console.WriteLine("Please press any key:");
                    Console.ReadKey();
                }
                
                if (menu == -1)
                {
                    return;
                }
            }
        }

        public static void ShowAllPersons()
        {
            Console.Clear();
            Console.WriteLine("{0,-24} | {1,-24} | {2,-24} | {3,-11}", "Name", "Surname", "Patronymic", "Birthday");
            foreach (var person in _list)
            {
                Console.WriteLine("{0,-24} | {1,-24} | {2,-24} | {3,-11}", 
                    person.Name, person.Surname, person.Patronymic, person.Birthday.ToShortDateString());
            }
            
            Console.WriteLine("Please press any key:");
            Console.ReadKey();
        }
    }
}