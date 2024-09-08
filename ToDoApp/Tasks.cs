using System;
using System.Collections.Generic;


namespace ToDoApp
{
    internal class Tasks
    {
        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nTo-Do List App");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. Read All Tasks");
                Console.WriteLine("3. Remove a Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ReadTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        return;  // This exits the loop and ends the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void AddTask()
        {
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added!");
        }

        static void ReadTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("\nTasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }

        static void RemoveTask()
        {
            ReadTasks();
            Console.Write("Enter the number of the task to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber-1);
                Console.WriteLine("Task removed!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}
     

