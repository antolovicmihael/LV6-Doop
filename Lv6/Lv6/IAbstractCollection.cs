using System;
using System.Collections.Generic;
using System.Text;

namespace Lv6
{
    interface IAbstractCollection
    {

        IAbstractIterator GetIterator();
    }
}
