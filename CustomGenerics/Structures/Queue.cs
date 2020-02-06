using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Interfaces;
using System.Collections;

namespace CustomGenerics.Structures
{
    public class Queue<T> : LinearDataStructureBase<T>, IEnumerable<T>
    {
        private Node<T> First { get; set; }
        public void Enqueue(T value)
        {
            Insert(value);
        }

        public T Dequeue()
        {
            var value = Get();
            Delete();
            return value;
        }
        protected override void Insert(T value)
        {
            if (First == null)
            {
                First = new Node<T>
                {
                    Value = value,
                    Next = null
                };
            }
            else
            {
                var current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>
                {
                    Value = value,
                    Next = null
                };
            }
        }


        protected override void Delete()
        {
            if (First != null)
            {
                First = First.Next;
            }
            
        }

        protected override T Get()
        {
            return First.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var queueCopy = this;
            while (queueCopy.First != null)
            {
                yield return queueCopy.Dequeue();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
