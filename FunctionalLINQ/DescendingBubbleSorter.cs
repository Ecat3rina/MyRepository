using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalLINQ
{
    class DescendingBubbleSorter
    {
        public delegate bool IsASmallerThanBDelegate(object a, object b);
        public static void Sort(object[] objects, IsASmallerThanBDelegate IsASmallerThanB)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < objects.Length - 1; i++)
                {
                    if (IsASmallerThanB(objects[i], objects[i + 1]))
                    {
                        object temp = objects[i];
                        objects[i] = objects[i + 1];
                        objects[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
       /* public static int IsASmallerThanB_Name(object a, object b)
        {
            return (((Country)a).Name).CompareTo(((Country)b).Name);
        }*/
        public static bool IsASmallerThanB_Area(object a, object b)
        {
            return (((Country)a).Area< ((Country)b).Area);
        }
        public static bool IsASmallerThanB_Population(object a, object b)
        {
            return (((Country)a).Population < ((Country)b).Population);
        }
       
    }
}
