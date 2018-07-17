using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IBaseMapper<T, V>
    {
        V Create();

        V Convert(T source);

        T Convert(V source);

        IEnumerable<V> Convert(IEnumerable<T> source);

        IEnumerable<T> Convert(IEnumerable<V> source);
    }
}
