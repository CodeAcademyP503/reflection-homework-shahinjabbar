using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfaTechnologies.Models
{
   public abstract class Entity<T>
    {
        public int Id { get; set; }
        public abstract void Update(T item);
    }
}
