using System;
using System.Collections.Generic;
using System.Text;

namespace Lv6
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}
