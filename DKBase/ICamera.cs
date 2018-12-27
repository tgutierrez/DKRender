using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Base
{
    public interface ICamera
    {
        int Height { get; }
        int Width { get; }
        float FOV { get; }
        float AspectRatio { get; }
        float Angle { get; }
    }
}
