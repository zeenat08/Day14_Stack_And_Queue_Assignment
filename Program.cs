using DataStructures.Linked_List;
using System;
using DataStructures.QueueUsingLinkedList1;
using DataStructures.StackUsingLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();



            #endregion

            #region QueueUsingLikedList
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            //this.top = this.top.next;

            #endregion

            #region StackCode
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek(); //top.data
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();

            #endregion
            Console.ReadKey();
        }
    }
}
