namespace AlgorithmPractice.Udemy.LinkedLists
{
    public static class DoublyLinkedListImplementation
    {
        public static void Run()
        {
            var doublyLinkedList = new DoublyLinkedList(10);
            doublyLinkedList.Append(7);
            doublyLinkedList.Append(16);
            doublyLinkedList.Prepend(5);
            doublyLinkedList.Insert(1, 99);
            doublyLinkedList.Remove(1);

            doublyLinkedList.PrintList();
        }
    }

    public class NodeDoub
    {
        public int Value { get; set; }
        public NodeDoub Next { get; set; }
        public NodeDoub Previous { get; set; }

        public NodeDoub(int value)
        {
            this.Value = value;
        }
    }

    public class DoublyLinkedList
    {
        public NodeDoub Head;
        public NodeDoub Tail;
        private int Length;

        public DoublyLinkedList(int value)
        {
            this.Head = new NodeDoub(value);
            this.Tail = this.Head;
            this.Length = 1;
        }

        public void Append(int value)
        {
            var newNode = new NodeDoub(value);
            newNode.Previous = this.Tail;
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        public void Prepend(int value)
        {
            var newNode = new NodeDoub(value);
            newNode.Next = this.Head;
            this.Head.Previous = newNode;
            this.Head = newNode;
            this.Length++;
        }

        public void Insert(int index, int value)
        {
            index = this.WrapIndex(index);
            if (index == 0)
            {
                Prepend(value);
                return;
            }

            if (index == this.Length - 1)
            {
                Append(value);
                return;
            }

            var newNode = new NodeDoub(value);

            var leader = this.TraverseToIndex(index - 1);
            var follower = leader.Next;

            leader.Next = newNode;
            newNode.Previous = leader;
            newNode.Next = follower;
            follower.Previous = newNode;

            this.Length++;
        }

        public void Remove(int index)
        {
            index = this.WrapIndex(index);

            if (index == 0)
            {
                this.Head = this.Head.Next;
                return;
            }

            var leader = this.TraverseToIndex(index - 1);

            var nodeToRemove = leader.Next;
            leader.Next = nodeToRemove.Next;
            nodeToRemove.Next.Previous = leader;
            this.Length--;
        }

        public void PrintList()
        {
            if (this.Head == null)
            {
                return;
            }

            var current = this.Head;
            while (current != null)
            {
                Console.Write("-->" + current.Value);
                current = current.Next;
            }

            Console.WriteLine();
        }

        private NodeDoub TraverseToIndex(int index)
        {
            int counter = 0;
            var currentNode = this.Head;
            index = WrapIndex(index);

            while (counter != index)
            {
                currentNode = currentNode.Next;
                counter++;
            }

            return currentNode;
        }

        private int WrapIndex(int index)
        {
            return Math.Max(Math.Min(index, this.Length - 1), 0);
        }
    }
}
