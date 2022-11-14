namespace AlgorithmPractice.Udemy.LinkedLists
{
    public static class SinglyLinkedListImplementation
    {
        public static void Run()
        {
            var linkedList = new SinglyLinkedList(22);
            linkedList.Append(2);
            linkedList.Append(77);
            linkedList.Append(6);
            linkedList.Reverse();
            linkedList.Insert(1, 69);
            linkedList.Prepend(1);
            linkedList.Insert(20, 7);
            linkedList.Remove(2);
            linkedList.PrintList();
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

    public class SinglyLinkedList
    {
        public Node Head;
        public Node Tail;
        private int Length;

        public SinglyLinkedList(int value)
        {
            this.Head = new Node(value);
            this.Tail = this.Head;
            this.Length = 1;
        }

        public void Append(int value)
        {
            var newNode = new Node(value);
            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Length++;
        }

        public void Prepend(int value)
        {
            var newNode = new Node(value);
            newNode.Next = this.Head;
            this.Head = newNode;
            this.Length++;
        }

        public void Insert(int index, int value)
        {
            index = this.WrapIndex(index);

            if (index == 0)
            {
                this.Prepend(value);
                return;
            }

            if (index == this.Length - 1)
            {
                this.Append(value);
                return;
            }

            var newNode = new Node(value);

            var leader = this.TraverseToIndex(index - 1);
            var holdingPointer = leader.Next;

            leader.Next = newNode;
            newNode.Next = holdingPointer;
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
            this.Length--;
        }

        public void Reverse()
        {
            var first = this.Head;
            var second = first.Next;
            this.Tail = this.Head;

            for (int i = 0; i < this.Length - 1; i++)
            {
                var temp = second.Next;
                second.Next = first;
                first = second;
                second = temp;
            }

            this.Head.Next = null;
            this.Head = first;
        }

        public void PrintList()
        {
            if (this.Head == null)
            {
                return;
            }

            Node current = this.Head;

            while (current != null)
            {
                Console.Write($"--> {current.Value}");
                current = current.Next;
            }

            Console.WriteLine();
        }

        private Node TraverseToIndex(int index)
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
