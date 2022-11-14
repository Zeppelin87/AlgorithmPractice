namespace AlgorithmPractice.Udemy.Arrays
{
    public static class RunMyArray
    {
        public static void Run()
        {
            var myArray = new MyArray();

            myArray.Push("Hello");
            myArray.Push("World");
            myArray.Push("!");

            myArray.Delete(1);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray.Get(i));
            }
        }
    }

    public class MyArray
    {
        public int Length;
        private object[] Data;

        public MyArray()
        {
            this.Length = 0;
            this.Data = new object[1];
        }

        public object Get(int index)
        {
            return Data[index];
        }

        // Push items at last index
        public object[] Push(object item)
        {
            if (this.Data.Length == this.Length)
            {
                // Creates temp array.
                var temp = new object[this.Length];

                // Copies all data to the temp array.
                Array.Copy(this.Data, temp, this.Length);

                // Increases the size of the array.
                this.Data = new object[this.Length + 1];

                Array.Copy(temp, this.Data, this.Length);
            }

            this.Data[this.Length] = item;
            this.Length++;
            return this.Data;
        }

        // Remove the last item of the array.
        public object Pop()
        {
            var lastItem = this.Data[this.Data.Length - 1];
            this.Data[this.Data.Length - 1] = null;
            this.Length--;
            return lastItem;
        }

        public object Delete(int index)
        {
            var itemToDelete = Data[index];
            ShiftItems(index); // Shifts the items at the given index.
            return itemToDelete;
        }

        private void ShiftItems(int index)
        {
            for (int i = index; i < this.Length - 1; i++)
            {
                Data[i] = Data[i + 1];
            }

            Data[this.Length - 1] = null;
            Length--;
        }
    }
}
