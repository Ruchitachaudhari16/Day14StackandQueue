using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueuePracticeProblem
{
    public class Program
    {
        //UC1 Ability to create a Stack of 56->30->70
        //LIFO
        //56 will be on the top of the stack
        static void Main(string[] args)
        { 
            LinkedListStack linkListStack = new LinkedListStack();
            linkListStack.Push(70);
            linkListStack.Push(30);
            linkListStack.Push(56);
            Console.WriteLine("Data inserted in a stack");
            linkListStack.Display();
            Console.WriteLine("Peek element from the stack");
            linkListStack.Peek();
            Console.WriteLine("Pop element from the stack");
            linkListStack.Pop();
            Console.WriteLine("Element in the stack after pop");
            linkListStack.Display();
            Console.ReadLine();
        }
}
    }

