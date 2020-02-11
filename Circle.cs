using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tluong_QA_A1
{
    public class Circle
    {
        private int _radius;
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                // ensure non-negative radius value 
                if (value >= 1)
                    _radius = value;
            }
        }

        //Default constructor
        public Circle()
        {
            this.Radius = 1;
        }
        //Custom constructor
        public Circle (int radius)
        {
            this.Radius = radius;
        }

        public int GetRadius()
        {
            Radius = _radius;
            return Radius;
        }

        public void SetRadius(int Rad)
        {
            if (Rad >= 0)
            _radius = Rad;
        }

        public double GetCircumference()
        {
            int r = GetRadius();
            double C = 2 * Math.PI * r;
            return C;
        }

        public double GetArea()
        {
            int r = GetRadius();
            double A = Math.PI * r * r;
            return A;
        }
    }
}
