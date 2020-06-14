using System;
using System.Collections.Generic;

namespace Lab1
{

    class Program
    {
        static void Main(string[] args)
        {
            Lab1.Stack<int> MyStack = new Stack<int>();
            System.Collections.Generic.Stack<int> MicrosoftStack = new System.Collections.Generic.Stack<int>();

            var startTime = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
                MyStack.Push(i);
            MyStack.Contains(3);
            MyStack.Peek();
            for (int i = 0; i < 100000; i++)
                MyStack.Pop();

            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            Console.WriteLine("Время работы моего стека {0}", elapsedTime);




            startTime = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
                MicrosoftStack.Push(i);
            MicrosoftStack.Contains(3);
            MicrosoftStack.Peek();
            for (int i = 0; i < 100000; i++)

                MicrosoftStack.Pop();

            startTime.Stop();
            resultTime = startTime.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                resultTime.Hours,
                resultTime.Minutes,
                resultTime.Seconds,
                resultTime.Milliseconds);

            Console.WriteLine("Время работы стека майкрософт {0}", elapsedTime);


        }
    }
}
