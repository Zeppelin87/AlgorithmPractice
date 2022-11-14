namespace AlgorithmPractice.DataStructures
{
    public static class MinHeap
    {
        public static void Run()
        {

        }
    }

    public class MinimumHeap
    {
        public int[] HeapArray { get; set; }
        public int Capacity { get; set; }
        public int CurrentHeapSize { get; set; }

        public MinimumHeap(int n)
        {
            Capacity = n;
            HeapArray = new int[Capacity];
            CurrentHeapSize = 0;
        }

        public int Parent(int key)
        {
            return (key - 1) / 2;
        }

        public int Left(int key)
        {
            return (2 * key) + 1;
        }

        public int Right(int key)
        {
            return (2 * key) + 2;
        }

        // Inserts a new key.
        public bool InsertKey(int key)
        {
            if (CurrentHeapSize == Capacity)
            {
                // Heap is full.
                return false;
            }

            // First insert the new key at the end.
            int i = CurrentHeapSize;
            HeapArray[i] = key;
            CurrentHeapSize++;

            // Fix the min heap property if it's violated.
            while (i != 0 && HeapArray[i] < HeapArray[Parent(i)])
            {
                Swap(ref HeapArray[i], ref HeapArray[Parent(i)]);
                i = Parent(i);
            }

            return true;
        }

        // Returns the minimum key (key at root) for min heap.
        public int GetMin()
        {
            return HeapArray[0];
        }

        // Method to remove minimum element (or root) from min heap.
        public int ExtractMin()
        {
            if (CurrentHeapSize <= 0)
            {
                return int.MaxValue;
            }

            if (CurrentHeapSize == 1)
            {
                CurrentHeapSize--;
                return HeapArray[0];
            }

            // Store the min value, and remove it from the heap.
            int root = HeapArray[0];

            HeapArray[0] = HeapArray[CurrentHeapSize - 1];
            CurrentHeapSize--;
            MinHeapify(0);

            return root;
        }

        // This function deletes the key at the given index.
        // It first reduced value to minus infinite, then calls ExtractMin();
        public void DeleteKey(int key)
        {
            DecreaseKey(key, int.MinValue);
            ExtractMin();
        }

        // Increases the value of the given key to newValue.
        // It's assumed that newValue is greater than HeapArray[key].
        // Heapify from the given key.
        public void IncreaseKey(int key, int newValue)
        {
            HeapArray[key] = newValue;
            MinHeapify(key);
        }

        // Decreases the value of the given key to newValue.
        // It's assumed that the newValue is smaller than HeapArray[key].
        public void DecreaseKey(int key, int newValue)
        {
            HeapArray[key] = newValue;

            while (key != 0 && HeapArray[key] < HeapArray[Parent(key)])
            {
                Swap(ref HeapArray[key], ref HeapArray[Parent(key)]);
                key = Parent(key);
            }
        }

        // Changes the value on a key.
        public void ChangeValueOnAKey(int key, int newValue)
        {
            if (HeapArray[key] == newValue)
            {
                return;
            }

            if (HeapArray[key] < newValue)
            {
                IncreaseKey(key, newValue);
            }
            else
            {
                DecreaseKey(key, newValue);
            }
        }

        // A recursive method to heapify a subtree with the root at a given index.
        // This method assumes that the subtrees are already heapified.
        public void MinHeapify(int key)
        {
            int l = Left(key);
            int r = Right(key);

            int smallest = key;

            if (l < CurrentHeapSize && HeapArray[l] < HeapArray[smallest])
            {
                smallest = l;
            }

            if (r < CurrentHeapSize && HeapArray[r] < HeapArray[smallest])
            {
                smallest = r;
            }

            if (smallest != key)
            {
                Swap(ref HeapArray[key], ref HeapArray[smallest]);
                MinHeapify(smallest);
            }
        }

        public void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
