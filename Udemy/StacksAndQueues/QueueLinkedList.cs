namespace AlgorithmPractice.Udemy.StacksAndQueues
{
    public static class QueueLinkedList
    {
        public static void Run()
        {
            var queue = new QueueExample();
            queue.Enqueue(10);
            queue.Enqueue(7);
            queue.Enqueue(26);
            queue.PrintQueue();
            Console.WriteLine(queue.Dequeue());
            queue.PrintQueue();
        }
    }

    public class QueueExample
    {
        public Node First;
        public Node Last;
        public int Length;

        public QueueExample()
        {
            this.First = null;
            this.Last = null;
            this.Length = 0;
        }

        public void Enqueue(int value)
        {
            var newNode = new Node(value);

            if (this.Length == 0)
            {
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                this.Last = newNode;
            }

            this.Length++;
        }

        public int Dequeue()
        {
            if (this.First == null)
            {
                return -1;
            }

            if (this.Length == 0)
            {
                this.Last = null;
            }

            var holdingPointer = this.First;
            this.First = this.First.Next;
            this.Length--;

            return holdingPointer.Value;
        }

        public int Peek()
        {
            if (this.Length > 0)
            {
                return this.First.Value;
            }

            return -1;
        }

        public void PrintQueue()
        {
            if (this.First == null)
            {
                return;
            }

            var currentNode = this.First;
            Console.Write(currentNode.Value);

            currentNode = currentNode.Next;

            while (currentNode != null)
            {
                Console.Write("-->" + currentNode.Value);
                currentNode = currentNode.Next;
            }

            Console.WriteLine();
        }
    }
}
