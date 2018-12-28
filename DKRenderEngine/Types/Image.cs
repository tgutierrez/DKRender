using DKRender.Base.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Image : IImage
    {
        public IColor[,] Canvas {  get; private set; }
        public Image(int height, int width)
        {
            Canvas = new Pixel[height, width];
        }
    }
}
