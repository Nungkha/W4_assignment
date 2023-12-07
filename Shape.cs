using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_assignment
{
    internal class Shape
    {
        public virtual float CalculateArea()
        {
            return 0;
        }

    }

    internal class Cirlcle : Shape
    {
        private float _radius;
        public Cirlcle(float radius)
        {
            this._radius = radius;
        }
        public override float CalculateArea()
        {
            return (float)(Math.PI *  Math.Pow(_radius, 2));
        }
    }
}
