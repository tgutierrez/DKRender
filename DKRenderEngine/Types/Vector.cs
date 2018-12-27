using DKRender.Base.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Vector : IVector
    {
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X {get; private set;}
        public double Y {get; private set; }
        public double Z {get; private set; }

        public void Normalize()
        {
            double nor2 = Length2();
            if (nor2 > 0)
            {
                double invNor = 1 / Math.Sqrt(nor2);
                X *= invNor;
                Y *= invNor;
                Z *= invNor;
            }
        }

        public double Length()
        {
            return Math.Sqrt(Length2());
        }

        private double Length2()
        {
            return X * X + Y * Y + Z * Z;
        }
    }
}
