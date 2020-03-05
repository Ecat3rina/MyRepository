using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Interfaces
{
    class DegreesComparer: IComparer
    {
        int IComparer.Compare(object x, object y) 
        {
            Angle t1 = (Angle)x;
            Angle t2 = (Angle)y;
            return t1.degrees.CompareTo(t2.degrees);
        }
    }
}
