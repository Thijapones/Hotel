using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Base
{
    public abstract class Repository<T> : IRepository<T>
    {
        private static List<T> _list;
        private static object _syncObj = new object();
        public Repository()
        {
            if (_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
        }
        public bool Add(T obj)
        {
            _list.Add(obj);

            return true;
        }

        public List<T> GetList()
        {
            return _list;
        }
    }
}
