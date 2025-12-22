using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Entities.AbstracClass
{
    public abstract class EntityBase
    {
        public int id { get; set; }

        public string name { get; set; }

        public bool isActive { get; set; }

        public DateTime createdDate { get; set; }

        public object Get(int id) { }

        public object Update (int id) { }

        public object Delete(int id) { }

        public T Create<T> (Dictionary<string, object>) { }
    }
}
