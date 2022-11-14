using System.Text;

namespace AlgorithmPractice.Udemy.Graphs
{
    public static class GraphExample
    {
        public static void Run()
        {
            var graph = new MyGraph();
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(6, 5);
            graph.ShowConnections();
        }
    }

    public class MyGraph
    {
        public IDictionary<int, List<int>> AdjacentList;
        public int NumberOfNodes;

        public MyGraph()
        {
            AdjacentList = new Dictionary<int, List<int>>();
            NumberOfNodes = 0;
        }

        public void AddVertex(int value)
        {
            AdjacentList.Add(value, new List<int>());
            NumberOfNodes++;
        }

        public void AddEdge(int value1, int value2)
        {
            AdjacentList[value1].Add(value2);
            AdjacentList[value2].Add(value1);
        }

        public void ShowConnections()
        {
            foreach (var item in AdjacentList)
            {
                List<int> nodeConnections = AdjacentList[item.Key];
                var connections = new StringBuilder();

                foreach (int edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }

                Console.WriteLine(item.Key + "-->" + connections);
            }
        }
    }
}
