using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Deck<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
