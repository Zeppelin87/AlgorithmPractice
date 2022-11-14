namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_DijkstrasAlgorithm
    {
        public static void Run()
        {
            int start = 0;

            int[][][] edges = {
                new int[][] { new int[] { 1, 7 } },
                new int[][] { new int[] { 2, 6 }, new int[] { 3, 20 }, new int[] { 4, 3 } },
                new int[][] { new int[] { 3, 14 } },
                new int[][] { new int[] { 4, 2 } },
                new int[][] { },
                new int[][] { },
            };

            // O((v + e) * log(v)) time complexity | O(v) space complexity.
            // Where: 'n' is the number of vertices & 'e' is the number of edges in the input graph.
            var result = Solution(start, edges);
        }

        private static int[] Solution(int start, int[][][] edges)
        {
            int numberOfVertices = edges.Length;

            int[] minDistances = new int[numberOfVertices];
            Array.Fill(minDistances, int.MaxValue);
            minDistances[start] = 0;

            var minDistancesPairs = new List<Item>();
            for (int i = 0; i < numberOfVertices; i++)
            {
                var item = new Item(i, int.MaxValue);
                minDistancesPairs.Add(item);
            }

            var minDistancesHeap = new MinHeap(minDistancesPairs);
            minDistancesHeap.Update(start, 0);

            while (!minDistancesHeap.IsEmpty())
            {
                Item heapItem = minDistancesHeap.Remove();
                int vertex = heapItem.Vertex;
                int currentMinDistance = heapItem.Distance;

                if (currentMinDistance == int.MaxValue)
                {
                    break;
                }

                foreach (var edge in edges[vertex])
                {
                    int destination = edge[0];
                    int distanceToDestination = edge[1];
                    int newPathDistance = currentMinDistance + distanceToDestination;
                    int currentDestinationDistance = minDistances[destination];

                    if (newPathDistance < currentDestinationDistance)
                    {
                        minDistances[destination] = newPathDistance;
                        minDistancesHeap.Update(destination, newPathDistance);
                    }
                }
            }

            int[] finalDistances = new int[minDistances.Length];
            for (int i = 0; i < minDistances.Length; i++)
            {
                int distance = minDistances[i];
                if (distance == int.MaxValue)
                {
                    finalDistances[i] = -1;
                }
                else
                {
                    finalDistances[i] = distance;
                }
            }

            return finalDistances;
        }
    }

    public class Item
    {
        public int Vertex;
        public int Distance;

        public Item(int vertex, int distance)
        {
            this.Vertex = vertex;
            this.Distance = distance;
        }
    }

    public class MinHeap
    {
        Dictionary<int, int> vertexDictionary = new Dictionary<int, int>();
        List<Item> heap = new List<Item>();

        public MinHeap(List<Item> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Item item = array[i];
                vertexDictionary[item.Vertex] = item.Vertex;
            }

            heap = BuildHeap(array);
        }

        public List<Item> BuildHeap(List<Item> array)
        {
            int firstParentIdx = (array.Count - 2) / 2;
            for (int currentIdx = firstParentIdx + 1; currentIdx >= 0; currentIdx--)
            {
                SiftDown(currentIdx, array.Count - 1, array);
            }

            return array;
        }

        public void Update(int vertex, int value)
        {
            heap[vertexDictionary[vertex]] = new Item(vertex, value);
            SiftUp(vertexDictionary[vertex]);
        }

        public Item Remove()
        {
            Swap(0, heap.Count - 1);
            Item lastItem = heap[heap.Count - 1];
            int vertex = lastItem.Vertex;
            int distance = lastItem.Distance;

            heap.RemoveAt(heap.Count - 1);
            vertexDictionary.Remove(vertex);
            SiftDown(0, heap.Count - 1, heap);
            return new Item(vertex, distance);

        }

        private void SiftUp(int currentIdx)
        {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx > 0 && heap[currentIdx].Distance < heap[parentIdx].Distance)
            {
                Swap(currentIdx, parentIdx);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
        }

        private void SiftDown(int currentIdx, int endIdx, List<Item> heap)
        {
            int childOneIdx = currentIdx * 2 + 1;
            while (childOneIdx <= endIdx)
            {
                int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;
                int idxToSwap;

                if (childTwoIdx != -1 && heap[childTwoIdx].Distance < heap[childOneIdx].Distance)
                {
                    idxToSwap = childTwoIdx;
                }
                else
                {
                    idxToSwap = childOneIdx;
                }

                if (heap[idxToSwap].Distance < heap[currentIdx].Distance)
                {
                    Swap(currentIdx, idxToSwap);
                    currentIdx = idxToSwap;
                    childOneIdx = currentIdx * 2 + 1;
                }
                else
                {
                    return;
                }
            }
        }

        public bool IsEmpty()
        {
            return heap.Count == 0;
        }

        private void Swap(int i, int j)
        {
            vertexDictionary[heap[i].Vertex] = j;
            vertexDictionary[heap[j].Vertex] = i;

            Item temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
