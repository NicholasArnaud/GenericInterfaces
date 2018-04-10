using System;

namespace Interfaces
{
    public interface IEnumerable<T>
    {

        T Add<T>(T a, T b);
    }

    public class Interface<T> : IEnumerable<T>
    {
        public T Add<T>(T a, T b)
        {
            var c = (int)(object)b;
            var d = (int)(object)a;
            var total = d + c;
            return (T)(object)total;
        }
    }
}
