using DKRender.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Attempting to port https://www.scratchapixel.com/code.php?id=3&origin=/lessons/3d-basic-rendering/introduction-to-ray-tracing to c#
/// </summary>
namespace DKRender.Engine
{
    public class Engine : IEngine
    {
        public void Render(IScene scene)
        {
            int height = scene.Camera.Height;
            int width = scene.Camera.Width;
            // initialize image canvas
            var image = new Types.Image(height, width);
            float invHeight = 1 / (float)height;
            float invWidth = 1 / (float)width;

        }
    }
}
