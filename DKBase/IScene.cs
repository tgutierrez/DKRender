using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Base
{
    public interface IScene
    {
        IEnumerable<IGeometryObject> Objects { get; }
        ICamera Camera { get; }
    }
}
