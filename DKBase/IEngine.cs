using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Base
{
    public interface IEngine
    {
        /// <summary>
        /// Renders a scene
        /// </summary>
        /// <param name="scene"></param>
        void Render(IScene scene);
    }
}
