using DKRender.Base;
using DKRender.Engine.Types;
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
            double angle = scene.Camera.Angle;
            double aspectRatio = scene.Camera.AspectRatio;
            // initialize image canvas
            var image = new Types.Image(height, width);
            double invHeight = 1 / (double)height;
            double invWidth = 1 / (double)width;

            for (int y = 0; y < height; ++y) {
                for (int x = 0; x < width; ++x) {
                    double xx = ((2 * ((x + 0.5) * invWidth)) - 1) * angle * aspectRatio;
                    double yy = (1 - (2 * ((y + 0.5) * invHeight))) * angle;
                    Vector rayDirection = new Vector(xx, yy, -1);
                    rayDirection.Normalize();
                    image.Canvas[x, y] = Trace(new Vector(0, 0, 0), rayDirection, scene.Objects, 0);
                }
            }
        }

        public Pixel Trace(Vector origin, Vector direction, IEnumerable<IGeometryObject> objects, int depth)
        {
            throw new NotImplementedException();
        }
    }
}
