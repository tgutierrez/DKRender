using DKRender.Base.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKRender.Engine.Types
{
    public class Pixel : IColor
    {
        public float R{ get; set; }
        public float G{ get; set; }
        public float B{ get; set; }
    }
}
