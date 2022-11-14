namespace AlgorithmPractice.Udemy.Algorithms.Searching
{
    public static class BreadthFirstSearchExample
    {
        public static void Run()
        {
            var tree = new BinarySearchTree();
            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);

            var result = BreathFirstSearch(tree.Root);

            foreach (var item in result)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();

            //Recurcive call
            var list = new List<int>();
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(tree.Root);
            var result2 = RecursiveBreathFirstSearch(queue, list);

            foreach (var item in result2)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
        }

        public static IList<int> BreathFirstSearch(Node currentNode)
        {
            var list = new List<int>();

            var queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                list.Add(currentNode.Value);

                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
            }

            return list;
        }

        //Recursive BFS
        public static IList<int> RecursiveBreathFirstSearch(Queue<Node> queue, IList<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode = queue.Dequeue();
            list.Add(currentNode.Value);

            if (currentNode.Left != null)
            {
                queue.Enqueue(currentNode.Left);
            }

            if (currentNode.Right != null)
            {
                queue.Enqueue(currentNode.Right);
            }

            return RecursiveBreathFirstSearch(queue, list);
        }
    }
}
