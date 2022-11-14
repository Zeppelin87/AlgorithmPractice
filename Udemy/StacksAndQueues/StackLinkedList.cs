namespace AlgorithmPractice.Udemy.StacksAndQueues
{
    public static class StackLinkedList
    {
        public static void Run()
        {
            var stack = new StackExample();
            stack.Push(10);
            stack.Push(16);
            stack.Push(100);
            stack.PrintStack();
            Console.WriteLine(stack.Pop());
            stack.PrintStack();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    public class StackExample
    {
        public Node Top;
        public Node Bottom;
        public int Length;

        public StackExample()
        {
            this.Top = null;
            this.Bottom = null;
            this.Length = 0;
        }

        public void Push(int value)
        {
            var newNode = new Node(value);

            if (this.Length == 0)
            {
                this.Top = newNode;
                this.Bottom = newNode;
            }
            else
            {
                var holdingPointer = this.Top;
                this.Top = newNode;
                this.Top.Next = holdingPointer;
            }

            this.Length++;
        }

        public int Pop()
        {
            if (this.Top == null)
            {
                return -1;
            }

            var holdingPointer = this.Top;
            this.Top = this.Top.Next;
            this.Length--;

            return holdingPointer.Value;
        }

        public int Peak()
        {
            if (this.Length > 0)
            {
                return this.Top.Value;
            }

            return -1;
        }

        public void PrintStack()
        {
            if (this.Top == null)
            {
                return;
            }

            var currentNode = this.Top;

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
