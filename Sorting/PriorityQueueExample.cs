namespace AlgorithmPractice.Sorting
{
    public static class PriorityQueueExample
    {
        public static void Run()
        {
            // A Queue will .Dequeue elements in first come first serve order.
            // Whatever element is .Enqueue() first will be .Dequeue() first. 
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(3.0);
            queue.Enqueue(2.5);
            queue.Enqueue(4.0);
            queue.Enqueue(1.5);
            queue.Enqueue(2.0);

            while (queue.Any())
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine();

            // A PriorityQueue(s) elements will be put into some sort of order before we .Dequeue() the element(s).
            // In C#, the lowest number has the highest priority (bc it's actually a min-heap, the root node is the minimum).
            // Useful docs: https://code-maze.com/csharp-priority-queue/
            PriorityQueue<double, double> priorityQueue = new PriorityQueue<double, double>();
            priorityQueue.Enqueue(3.0, 4);
            priorityQueue.Enqueue(2.5, 3);
            priorityQueue.Enqueue(4.0, 5);
            priorityQueue.Enqueue(1.5, 1);
            priorityQueue.Enqueue(2.0, 2);

            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }
        }
    }
}
