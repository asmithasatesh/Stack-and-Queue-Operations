using System;

namespace Stack_and_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Creating object for stack and queue operations
            StackAndQueueOperations stack = new StackAndQueueOperations();

            //Push operations
            int count = 0;
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            //Display operation
            Console.Write("\n-----DISPLAYING STACK ELEMENTS-----\n\n");
            count=stack.Display();

            //Pop operation
            for(int i=0;i<=count;i++)
            {
                stack.Pop();

            }

        }
    }
}
