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
        double FOV { get; }
        double AspectRatio { get; }
        double Angle { get; }
    }
}
