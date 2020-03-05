using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone.DataStructures
{
    public class LinkedListSoln
    {
        static public LinkedListNode<string> FindLoop(LinkedList<string> L)
        {
            var p1 = L.First;
            var p2 = L.First;
            while (p2.Next != null && p2.Next.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next.Next;
                if (p1 == p2)
                {
                    p1 = L.First;
                    while (p1 != p2)
                    {
                        p1 = p1.Next;
                        p2 = p2.Next;
                    }
                    return (p2);
                }
            }

            return null;
        }
    }
}
