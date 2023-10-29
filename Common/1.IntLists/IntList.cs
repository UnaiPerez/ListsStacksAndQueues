using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using Common;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;
        

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        IntListNode Last = null;
        public int NumElements = 0;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            IntListNode node1 = Last;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            if(First == null)
            {
                First = new IntListNode(value);
            }
            else
            {
                Last = First;
                while(Last.Next != null)
                {
                    Last = Last.Next;
                }
                Last.Next = new IntListNode(value);

            }
            NumElements++;
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            if(index == 0)
            {
                return null;
            }
            else
            {
                IntListNode current = First;
                for (int i = 0; i < index && current != null; i++)
                {
                    current = current.Next;
                }

                return current;
            }
            
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            
                IntListNode num = GetNode(index);
                return num != null ? num.Value : 3;
            
            
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            return NumElements;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index < 0 || index >= NumElements)
            {
                return;
            }

            if (index == 0)
            {
                First = First.Next;
            }
            else
            {
                IntListNode prev = GetNode(index - 1);
                if (prev != null && prev.Next != null)
                {
                    prev.Next = prev.Next.Next;
                }
            }
            NumElements--;
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
        }
    }
}

  