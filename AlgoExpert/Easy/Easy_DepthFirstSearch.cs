namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_DepthFirstSearch
    {
        public static void Run()
        {
            // Time Complexity: O(n) - Linear.
            //  - visting every node in the graph.
            // Space Complexity: O(n) - Linear.
            //  - the 'array' contains every node in the graph, so size of 'n'.

            // string[] expected = {"A", "B", "E", "F", "I", "J", "C", "D", "G", "K", "H"};

            var graph = new Node("A");
            graph.AddChild("B").AddChild("C").AddChild("D");
            graph.children[0].AddChild("E").AddChild("F");
            graph.children[2].AddChild("G").AddChild("H");
            graph.children[0].children[1].AddChild("I").AddChild("J");
            graph.children[2].children[0].AddChild("K");

            var result = graph.DepthFirstSearch(new List<string>());
        }
    }

    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public Node AddChild(string name)
        {
            var child = new Node(name);
            children.Add(child);
            return this;
        }

        public List<string> DepthFirstSearch(List<string> array)
        {
            array = this.TraversePreOrder(this, array);
            return array;
        }

        // O(log n)
        private List<string> TraversePreOrder(Node graph, List<string> array)
        {
            array.Add(graph.name);

            // O(n)
            for (int i = 0; i < graph.children.Count; i++)
            {
                TraversePreOrder(graph.children[i], array);
            }

            return array;
        }
    }
}
