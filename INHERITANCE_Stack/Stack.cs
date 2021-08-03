using System;
using System.Collections;

namespace INHERITANCE_Stack
{
    public class Stack
    {
        private readonly ArrayList _stackObjects = new ArrayList();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();
            _stackObjects.Add(obj);
        }

        public object Pop()
        {
            if (_stackObjects.Count == 0)
                throw new InvalidOperationException();
            var item = _stackObjects[^1];
            _stackObjects.RemoveAt(_stackObjects.Count - 1);
            return item;
        }

        public void Clear()
        {
            _stackObjects.Clear();
        }
    }
}