using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeInheritance
{
    // abstract - Экземпляр класса не может быть создан
    public abstract class Shape
    {
        // virtual - метод может быть переопределен любым наследующим его классом
        public virtual string Name => nameof(Shape);

        public virtual float GetSize()
        {
            return default;
        }
    }
}
