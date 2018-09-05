using InfaTechnologies.Exceptions;
using InfaTechnologies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Core
{
    public class InMemoryDbSet<T> : IDbSet<T> where T : Entity<T>
    {
        private static List<T> _items;

        static InMemoryDbSet()
        {
            _items = new List<T>();
        }

        //Adding 
        public T Add(T item)
        {
            if (Exists(item) != null)
                throw new EntityExistsException("This entity alreadye exists");
            _items.Add(item);
            return item;
        }

        public T Exists(Func<T, bool> predicate)
        {
            T newItem = null;
            foreach (T _item in _items)
            {
                if (predicate(_item))
                {
                    newItem = _item;
                }
            }
            return newItem;
        }
        public T Exists(T item)
        {
            T newitem = null;
            foreach (T _item in _items)
            {
                if (_item.Equals(item))
                {
                    newitem = _item;
                }
            }
            return newitem;
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Update(T item)
        {
            var existsItem = Exists(item);
            if (existsItem == null)
                throw new EntityNotExistException("entity not exist for update");
            existsItem.Update(item);

            var k = _items;
        }

        public T GetById(int id)
        {
            T item = null;
            foreach (T _item in _items)
            {
                if (_item.Id == id)
                {
                    item = _item;
                }
            }
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}
