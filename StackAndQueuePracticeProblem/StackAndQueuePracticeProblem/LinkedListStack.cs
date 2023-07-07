﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueuePracticeProblem
{
   public class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Elements in Stack" + data);
        }
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
    }

