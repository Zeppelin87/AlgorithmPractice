namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MinHeapConstruction
    {
        public static void Run()
        {
            var minHeap = new MinHeap(new List<int>(){
                48, 12, 24, 7, 8, -5, 24, 391, 24, 56, 2, 6, 8, 41
            });

            minHeap.Insert(76);
            var firstCheck = IsMinHeapPropertySatisfied(minHeap.heap);

            if (minHeap.Peek() == -5)
            {
                var x = 1;
            }

            if (minHeap.Remove() == -5)
            {
                var y = 1;
            }

            var secondCheck = IsMinHeapPropertySatisfied(minHeap.heap);

            if (minHeap.Peek() == 2)
            {
                var z = 1;
            }

            if (minHeap.Remove() == 2)
            {
                var a = 1;
            }

            var thridCheck = IsMinHeapPropertySatisfied(minHeap.heap);

            if (minHeap.Peek() == 6)
            {
                var b = 1;
            }

            minHeap.Insert(87);
        }

        private static bool IsMinHeapPropertySatisfied(List<int> array)
        {
            for (int currentIdx = 1; currentIdx < array.Count; currentIdx++)
            {
                int parentIdx = (currentIdx - 1) / 2;
                if (parentIdx < 0)
                {
                    return true;
                }
                if (array[parentIdx] > array[currentIdx])
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class MinHeap
    {
        public List<int> heap = new List<int>();

        public MinHeap(List<int> array)
        {
            heap = buildHeap(array);
        }

        // O(n) time | O(1) space.
        public List<int> buildHeap(List<int> array)
        {
            // Call the SiftDown() method on every parent node in tree.
            // By using SiftDown() on every parent node, you effectively position every parent node correctly in the heap.
            // You start at the very last parent node.
            int firstParentIdx = (array.Count - 2) / 2;
            for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
            {
                siftDown(array, currentIdx, array.Count - 1);
            }

            return array;
        }

        // O(log(n)) time | O(1) space.
        public void siftDown(List<int> heap, int currentIdx, int endIdx)
        {
            // Swap the 'currentIdx' with either the 'leftChildIx' or 'rightChildIdx', whichever is smaller.
            int leftChildIdx = (2 * currentIdx) + 1;
            while (leftChildIdx < endIdx)
            {
                int rightChildIdx = (2 * currentIdx) + 2 <= endIdx ? (2 * currentIdx) + 2 : -1;
                int idxToSwap;

                if (rightChildIdx != -1 && heap[rightChildIdx] < heap[leftChildIdx])
                {
                    idxToSwap = rightChildIdx;
                }
                else
                {
                    idxToSwap = leftChildIdx;
                }

                if (heap[idxToSwap] < heap[currentIdx])
                {
                    Swap(heap, currentIdx, idxToSwap);
                    currentIdx = idxToSwap;
                    leftChildIdx = (2 * currentIdx) + 1;
                }
                else
                {
                    return;
                }
            }
        }

        // O(log(n)) time | O(1) space.
        public void siftUp(List<int> heap, int currentIdx)
        {
            // if 'currentNode' < 'parentNode': Swap().
            int parentIdx = (currentIdx - 1) / 2;

            while (currentIdx > 0 && heap[currentIdx] < heap[parentIdx])
            {
                Swap(heap, parentIdx, currentIdx);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
        }

        public int Peek()
        {
            return heap[0];
        }

        public int Remove()
        {
            // Swap root w/ last value in the heap.
            // Pop() last value, which is now the root, off the heap.
            // SiftDown() the new root, which was the last value on the heap before the initial 'root / last value' Swap().
            this.Swap(this.heap, 0, this.heap.Count - 1);

            int valueToRemove = this.heap[heap.Count - 1];
            this.heap.RemoveAt(this.heap.Count - 1);
            this.siftDown(heap, 0, this.heap.Count - 1);

            return valueToRemove;
        }

        public void Insert(int value)
        {
            // Add the value to the end of the array[] then SiftUp(value);
            this.heap.Add(value);
            this.siftUp(heap, heap.Count - 1);
        }

        public void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
