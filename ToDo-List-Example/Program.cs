using System;
using System.Collections.Generic;

namespace ToDo_List_Example
{
    class Program
    {
        enum UserChoice
        {
            AddTask = 1,
            DeleteTask,
            Exit
        }

        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();

            while (true)
            {
                if (toDoList.Count > 0)
                {
                    // If there are items in the to-do list, display them
                    Console.WriteLine("To-do List:");
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine("- " + toDoList[i]);
                    }
                    Console.WriteLine("");
                }
                else
                {
                    // No items in the to-do list
                    Console.WriteLine("You currently have no tasks in your To-do list.");
                    Console.WriteLine("");
                }

                // Print out the options to the user
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. Delete task");
                Console.WriteLine("3. Exit");

                // Get the user input (the action they want to do).
                int choice = int.Parse(Console.ReadLine());

                // If they select - Add task
                if (choice == (int)UserChoice.AddTask)
                {
                    // Ask the user to enter the task name, and add it to the list.
                    Console.Write("Enter task: ");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added successfully!");
                }

                // If they select - Delete task
                else if (choice == (int)UserChoice.DeleteTask)
                {
                    // re-print each item in the list, numbered, so the user can choose which one to delete.
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("Enter the number of the task you want to delete:");
                        for (int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
                        }
                    }

                    // Take the user's input. 
                    int taskNum = int.Parse(Console.ReadLine());

                    // Get corresponding index of the item in the array.
                    taskNum--;

                    if (taskNum >= 0 && taskNum < toDoList.Count)
                    {
                        // If the task exists, remove it
                        toDoList.RemoveAt(taskNum);
                        Console.Clear();
                        Console.WriteLine("Task deleted successfully!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        // IF the task doesn't exist
                        Console.Clear();
                        Console.WriteLine("Invalid task number.");
                        Console.WriteLine("");
                    }
                }

                // If they select - Exit
                else if (choice == (int)UserChoice.Exit)
                {
                    break;
                }
            }
        }
    }
}
