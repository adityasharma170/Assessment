using System;
using System.Collections;
using AssignmentLibrary;
namespace ConsoleApp10
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the predefined length of queue");
            int length=Convert.ToInt32( Console.ReadLine());
            Queue queue = new Queue();
            int count = QueueBuffer.Enqueue(queue , length);
            if(count==length)
            {
                Console.WriteLine("WARNING ! QUEUE IS FULL");
                int choice;
                Console.WriteLine("Do you want to overwrite and insert values? : \n 1-Yes  \n 2-No");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        queue.Clear();
                        Console.WriteLine("Insert values");
                        QueueBuffer.Enqueue(queue, length);
                        QueueBuffer.PrintQueue(queue);
                        break;
                    case 2:
                        QueueBuffer.PrintQueue(queue);
                        break;
                }

            }
            else
            {
                QueueBuffer.PrintQueue(queue);
            }
        }
    }
}
