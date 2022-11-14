namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_BreadthFirstSearch
    {
        public static void Run()
        {
            //var graph = new Node("A");
            //graph.AddChild("B").AddChild("C").AddChild("D");
            //graph.children[0].AddChild("E").AddChild("F");
            //graph.children[2].AddChild("G").AddChild("H");
            //graph.children[0].children[1].AddChild("I").AddChild("J");
            //graph.children[2].children[0].AddChild("K");

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes in the graph.
            //// Space Complexity: O(n) -- Linear.
            //var result = graph.Solution(new List<string>());
        }
    }

    //public class Node
    //{
    //    public string name;
    //    public List<Node> children = new List<Node>();

    //    public Node(string name)
    //    {
    //        this.name = name;
    //    }

    //    public Node AddChild(string name)
    //    {
    //        var child = new Node(name);
    //        this.children.Add(child);
    //        return this;
    //    }

    //    public List<string> Solution(List<string> array)
    //    {
    //        var queue = new Queue<Node>();
    //        queue.Enqueue(this);

    //        while (queue.Count > 0)
    //        {
    //            var node = queue.Dequeue();
    //            array.Add(node.name);

    //            if (node.children.Count > 0)
    //            {
    //                foreach (var child in node.children)
    //                {
    //                    queue.Enqueue(child);
    //                }
    //            }
    //        }

    //        return array;
    //    }
    //}
}
