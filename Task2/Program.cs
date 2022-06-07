using System;
using System.Collections.Generic;

namespace Task2
{
    internal partial class Program
    {
        private static List<Human> _list = new List<Human>();
        
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Add new person (1)"); 
                Console.WriteLine("Edit person (2)"); 
                Console.WriteLine("Delete person (3)");
                Console.WriteLine("Show detailed information about person (4)");
                Console.WriteLine("Show all persons (5)");
                Console.WriteLine("Exit (e)");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddPerson();
                        break;

                    case "2":
                        EditPerson();
                        break; 

                    case "3":
                        DeletePerson();
                        break;
                    
                    case "4":
                        ShowDetailPerson();
                        break;
                    
                    case "5":
                        ShowAllPersons();
                        break;
                    
                    case "e":
                        return;
                }
            }
        }
    }
}