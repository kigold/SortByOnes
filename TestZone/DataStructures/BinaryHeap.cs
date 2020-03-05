using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.DataStructures
{
    public class BinaryHeap
    {
        private List<int> _Heap { get; set; } = new List<int>();
        public void Insert(int entity)
        {
            _Heap.Add(entity);
        }
        public void Remove(int entity)
        {
            //Search for entity in the array
            int indexR = _Heap.FindIndex(x => x.Equals(entity));
            //Swap item with Top item
            Swap(indexR, _Heap.Count() - 1);
            //Then Bubble down
        }
        public int Poll()
        {
            //Remove root element
            //Swap it with Top element
            return _Heap.FirstOrDefault();
        }

        private void Swap(int indexA, int indexB)
        {
            var temp = _Heap[indexA];
            _Heap[indexA] = _Heap[indexB];
            _Heap[indexB] = temp;
        }

        public void Sort(int index=0)
        {
            var count = _Heap.Count();
            while(index < count)
            {
                //Sort the whole tree from this index
                var root = _Heap[index];
                int largestIndex = index;
                //Get Children
                var indexL = GetLeftIndex(index);
                var indexR = GetRightIndex(index);
                //Check if it violetes the rule
                if(indexL < count && root < _Heap[indexL])
                {
                    largestIndex = indexL;
                }
                if (indexR < count && root < _Heap[indexR])
                {
                    largestIndex = indexR;
                }
                if(largestIndex != index)
                {
                    Swap(index, largestIndex);

                    //Recursively sort
                    Sort(largestIndex);
                }
                //if so swap
                //Then check if this violets the rule, if so swap with the smallest, if there is a tie, then swap with left iteem
                index++;
            }
        }

        private void BubbbleUp(int index)
        {

        }
        private void BubbbleDown(int index)
        {

        }

        private int GetRightIndex(int index)
        {
            var i = (2 * index) + 2;

            return i;
        }
        private int GetLeftIndex(int index)
        {
            var i = (2 * index) + 1;
            return i;
        }

        public void PrintItems()
        {
            foreach(var item in _Heap)
            {
                Console.WriteLine(item);
            }
        }
    }
}
