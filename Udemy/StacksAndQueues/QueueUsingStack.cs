namespace AlgorithmPractice.Udemy.StacksAndQueues
{
    public static class QueueUsingStack
    {
        public static void Run()
        {
            var queue = new QueueWStack();
            queue.Enqueue(10);
            queue.Enqueue(7);
            queue.Enqueue(26);
            queue.PrintQueue();
            Console.WriteLine(queue.Dequeue());
            queue.PrintQueue();
        }
    }

    public class QueueWStack
    {
        public Stack<int> stack = new Stack<int>();
        public Stack<int> auxiliaryStack = new Stack<int>();

        public void Enqueue(int value)
        {
            this.stack.Push(value);
        }

        public int Dequeue()
        {
            this.FillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Pop();
            this.FillStackWithAuxiliaryStack();

            return value;
        }

        public int Peek()
        {
            this.FillAuxiliaryStackWithStack();
            int value = auxiliaryStack.Peek();
            this.FillStackWithAuxiliaryStack();

            return value;
        }

        public void PrintQueue()
        {
            if (stack.Count == 0)
            {
                return;
            }

            this.FillAuxiliaryStackWithStack();
            foreach (var i in auxiliaryStack)
            {
                Console.Write("-->" + i);
            }

            Console.WriteLine();
            this.FillStackWithAuxiliaryStack();
        }

        private void FillAuxiliaryStackWithStack()
        {
            //Making the "auxiliaryStack" stack as queue of "Stack"
            while (stack.Count > 0)
            {
                auxiliaryStack.Push(stack.Pop());
            }
        }

        private void FillStackWithAuxiliaryStack()
        {
            //Return stack to the original state
            while (auxiliaryStack.Count > 0)
            {
                stack.Push(auxiliaryStack.Pop());
            }
        }
    }
}
