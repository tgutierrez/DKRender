using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Base.Types
{
    public interface IVector
    {
        double X { get; }
        double Y { get; }
        double Z { get; }

        void Normalize();

        double Length();
    }
}
