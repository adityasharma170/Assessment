using System;
using System.Collections;
using System.Text;

namespace AssignmentLibrary
{
    public class QueueBuffer
    {
        public static int Enqueue(Queue queue, int length)
        {
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                queue.Enqueue(Console.ReadLine());
                count++;
            }
            return count;
        }


        public static void PrintQueue(Queue queue)
        {
            Console.WriteLine("Values inside queue");
            foreach (var id in queue)
                Console.WriteLine(id);
        }
    }
}
