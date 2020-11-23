using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample002
{
    public class MyClass : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        /// <summary>
        /// 巢狀類別
        /// </summary>
        private class Enumerator : IEnumerator<string>
        {
            private int _state = -1;
            public string Current { get; private set; }

            object IEnumerator.Current { get { return Current; } }

           

            public bool MoveNext()
            {
                switch (_state )
                {
                    case -1:
                        Current = "A";
                        _state++;
                        return true;
                    case 0:
                        Current = "B";
                        _state++;
                        return true;
                    case 1:
                        Current = "C";
                        _state++;
                        return true;
                    default:
                        return false;
                }
            }

            public void Reset()
            {
                _state = 0;
            }

            public void Dispose()
            {
                // 這裡先不管他
            }
        }

    }
}
