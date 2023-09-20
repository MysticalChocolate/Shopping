using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.source
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id {get; }
    }

    public class Item : Entity
    {

        public Item(string name, double value) 
        {
            _name = name;
            _value = value;
        }
        public string _name { get; }
        public double _value { get; }
    }

    public class Cart : Entity
    {
        private readonly HashSet<Item> _items = new();

        public IReadOnlyList<Item> Items => _items.ToList().AsReadOnly();
        public Cart Add(Item item) 
        {
            _items.Add(item);
            return this;
        }
            
    }

   /* public class CartController : Entity
    {

    }*/

}
