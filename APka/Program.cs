using System;
using System.IO;
using System.Text;

namespace APka
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Valentyn Kravchenko\Desktop\apka.txt";
            string[] tasks  = File.ReadAllLines(path);
           
            for ( ; ; )
            {
                Console.WriteLine("enter 1, to CONTINUE");
                Console.WriteLine("enter 2, for SHOW ELEMENTS");
                Console.WriteLine("enter 3, for ADD ELEMENT");
                Console.WriteLine("enter 4, for DELETE ELEMENT");
                Console.WriteLine("enter 5, for EXIT");

                int number = Convert.ToInt32(Console.ReadLine());
                if(number == 2)
                {
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ") " + tasks[i]);
                    }
                }
                if (number == 3)
                {
                    Console.WriteLine("Enter name of the new item");
                    string item = Convert.ToString(Console.ReadLine());

                    string[] newTasks =  new string[tasks.Length + 1];
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        newTasks[i] = tasks[i];
                    }
                    newTasks[newTasks.Length - 1] = item;
                    tasks = newTasks;
                    Console.WriteLine("New element was succesful added");
                    //for (int i = 0; i < newTasks.Length; i++)
                    //{
                    //    Console.WriteLine(newTasks[i]);
                    //}
                    
                }
                if (number == 4)
                {
                    Console.WriteLine("Enter number of the element which you wanna delete");

                int deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    
                    
                    if (deleteIndex >= tasks.Length || deleteIndex < 0)
                    {
                        Console.WriteLine("You entered incorrect index");
                    }
                    else
                    {
                        string[] newTasks2 = new string[tasks.Length - 1];
                        for (int i = 0; i < newTasks2.Length; i++)
                        {
                            newTasks2[i] = i < deleteIndex ? tasks[i] : tasks[i + 1];
                        }
                        tasks = newTasks2;
 
                    } 
                }
                File.WriteAllLines(path, tasks, Encoding.UTF8);

                if (number == 5)
                    break;
            }
        }
    }
}
