using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    public interface IEqualityComparer< in T>
    {
        bool Equals(T x, T y);                
    }
}
