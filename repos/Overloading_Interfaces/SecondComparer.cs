using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Interfaces
{
    class SecondComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Angle t1 = (Angle)x;
            Angle t2 = (Angle)y;
            return t1.seconds.CompareTo(t2.seconds);
        }
    }
}