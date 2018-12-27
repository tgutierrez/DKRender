using DKRender.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Camera : ICamera
    {
        private double _aspectRatio;
        private double _angle;

        public Camera(int width, int height, int fov)
        {
            Height = height;
            Width = width;
            FOV = fov;
            ComputeAspectRatio();
            ComputeAngle();
        }

        private void ComputeAngle()
        {
            //float angle = tan(M_PI * 0.5 * fov / 180.)
            _angle = Math.Tan(Math.PI * 0.5 * FOV / 180);
        }

        private void ComputeAspectRatio()
        {
            _aspectRatio = Width / (float)Height;
        }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public double FOV { get; private set;  }
        public double AspectRatio { get { return _aspectRatio; } }
        public double Angle { get { return _angle; } }
    }
}
