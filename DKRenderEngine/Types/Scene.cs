using DKRender.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Scene : IScene
    {
        public Scene(ICamera cam)
        {
            Camera = cam;
        }

        public IEnumerable<IGeometryObject> Objects => new List<IGeometryObject>();

        public ICamera Camera { get; private set; }
    }
}
