using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace Common.Mapper
{
    public class BaseMapper<T,V> : IBaseMapper<T,V>
                    where T : class
                    where V : class

    {
        public V Create()
        {
            return Activator.CreateInstance<V>();
        }

        public virtual V Convert(T source)
        {
            return Activator.CreateInstance<V>();
        }

        public virtual T Convert(V source)
        {
            return Activator.CreateInstance<T>();
        }

        public virtual IEnumerable<V> Convert(IEnumerable<T> source)
        {
            return null;
        }

        public virtual IEnumerable<T> Convert(IEnumerable<V> source)
        {
            return null;
        }
    }
}
