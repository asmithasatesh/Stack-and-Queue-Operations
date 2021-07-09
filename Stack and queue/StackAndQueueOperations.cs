﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_queue
{
    class StackAndQueueOperations
    {
        Node front;

        //Push data at Top
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            Append(newNode);
        }

        //Add data at top
        public void Append(Node newNode)
        {
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                Node temp = GetLastNode();
                temp.next = newNode;

            }
        }
        public Node GetLastNode()
        {
            Node temp = front;
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
        }

        //Display stack data
        public int Display()
        {
            Node temp = front;
            int count = 0;
            while (temp != null)
            {
                count++;
                Console.WriteLine("Stack element at {0} is: {1}", count, temp.data);
                temp = temp.next;
            }
            return count;
        }

    }
}
