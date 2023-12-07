using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_assignment
{
    internal class Rectangle
    {
        private float _length;
        private float _breadth;

        public Rectangle(float l, float b)
        {
            this._length = l;
            this._breadth = b;
        }

        public float CalculateArea()
        {
            float area = _length * _breadth; ;
            return area; 
        }


    }
}
