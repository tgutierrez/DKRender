using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Image
    {
        private Pixel[,] _canvas;

        public Pixel[,] Canvas
        {
            get { return _canvas; }
        }
        public Image(int height, int width)
        {
            _canvas = new Pixel[height, width];
        }
    }
}
