using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------- TO-DO LIST PROJECT
            /*
             * Allow users to input a task into the console
             * Add the console to a list
             * Allow user to print the list to the console
             * OPTIONAL:
             * Delete task 
             * Mark complete
             */
            

            List<string> toDoList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("Welcome to your To-Do List!\nPlease select an option:\n1 - Add to a task\n2 - Delete a task\n3 - Print your full list\ne - Exit program");
                Console.WriteLine();
                Console.Write("Option: ");
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine();
                    AddToList(toDoList);
                    Console.WriteLine();
                }
                else if (option == "2")
                {
                    Console.WriteLine();
                    DeleteFromList(toDoList);
                    Console.WriteLine();
                }
                else if (option == "3")
                {
                    Console.WriteLine();
                    PrintList(toDoList);
                    Console.WriteLine();
                }
                else if (option.ToLower() == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid option");
                    Console.WriteLine();
                }
            }
            
        }
        static void AddToList(List<string> list)
        {
            Console.Write("Enter a task: ");
            string task = Console.ReadLine();

            list.Add(task);
        }

        static List<string> PrintList(List<string> list)
        {
            if (list.Count < 1)
            {
                Console.WriteLine("Your list is currently empty");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"Task {i + 1} : {list[i]}");
                }
            }
            return list;
        }

        static void DeleteFromList(List<string> list)
        {
            Console.Write("Select which task to remove: ");
            int option = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (option == i + 1)
                {
                    list.Remove(list[i]);
                }
            }
        }
    }
}
