using System;
using System.Linq;

namespace Common
{
    public class IntArrayList : IList
    {
        int[] Values;
        int NumElements;

        public IntArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            Values = new int[n];
            NumElements = 0;
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i] + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #2: add a new integer to the end of the list
            if (NumElements < Values.Length)
            {
                Values[NumElements] = value;
                NumElements++;
            }
            else
            {
                
                Console.WriteLine("Array lleno");
            }
        }

        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. 
            return Values[index];
        }
        

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            return NumElements;
        }


       
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index >= 0 && index < NumElements)
            {
                for (int i = index; i < NumElements - 1; i++)
                {
                    Values[i] = Values[i + 1];
                }
                NumElements--;
            }
        }


        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            Values = null;
        }
    }
}