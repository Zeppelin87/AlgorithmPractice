using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MinMaxStackConstruction
    {
        public static void Run()
        {
            var stack = new MinMaxStack();
            stack.Push(5);
            stack.Push(7);
            stack.Push(2);

            int min = stack.GetMin();
            int max = stack.GetMax();
            int peek = stack.Peek();

            int pop1 = stack.Pop(); // 2
            int pop2 = stack.Pop(); // 7
        }
    }

    public class MinMaxStack
    {
        public List<int> stack = new List<int>();
        public List<Dictionary<string, int>> minMaxStack = new List<Dictionary<string, int>>();

        public MinMaxStack()
        {
            stack = new List<int>();
        }

        // O(1) time | O(1) space.
        public int Peek()
        {
            return stack[stack.Count - 1];
        }

        // O(1) time | O(1) space.
        public int Pop()
        {
            minMaxStack.RemoveAt(minMaxStack.Count - 1);
            int value = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return value;
        }

        // O(1) time | O(1) space.
        public void Push(int number)
        {
            var newMinMax = new Dictionary<string, int>();
            newMinMax.Add("min", number);
            newMinMax.Add("max", number);

            if (minMaxStack.Count > 0)
            {
                var lastMinMax = new Dictionary<string, int>(minMaxStack[minMaxStack.Count - 1]);
                newMinMax["min"] = Math.Min(lastMinMax["min"], number);
                newMinMax["max"] = Math.Max(lastMinMax["max"], number);
            }

            minMaxStack.Add(newMinMax);
            stack.Add(number);
        }

        // O(1) time | O(1) space.
        public int GetMin()
        {
            return minMaxStack[minMaxStack.Count - 1]["min"];
        }

        // O(1) time | O(1) space.
        public int GetMax()
        {
            return minMaxStack[minMaxStack.Count - 1]["max"];
        }
    }
}
