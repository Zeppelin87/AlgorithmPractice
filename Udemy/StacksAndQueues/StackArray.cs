using System.Collections;

namespace AlgorithmPractice.Udemy.StacksAndQueues
{
    public static class StackArray
    {
        public static void Run()
        {
            var stack = new StackArr();
            stack.Push(10);
            stack.Push(16);
            stack.Push(100);
            stack.PrintStack();
            Console.WriteLine(stack.Pop());
            stack.PrintStack();
        }
    }

    public class StackArr
    {
        public ArrayList Arr;

        public StackArr()
        {
            Arr = new ArrayList();
        }

        public void Push(int value)
        {
            this.Arr.Add(value);
        }

        public int Pop()
        {
            if (this.Arr.Count == 0)
            {
                return -1;
            }

            int lastItem = (int)this.Arr[this.Arr.Count - 1];
            this.Arr.RemoveAt(this.Arr.Count - 1);

            return lastItem;
        }

        public int Peek()
        {
            if (this.Arr.Count > 0)
            {
                return (int)this.Arr[this.Arr.Count - 1];
            }

            return -1;
        }

        public void PrintStack()
        {
            for (int i = this.Arr.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.Arr[i]);
            }
        }
    }
}
