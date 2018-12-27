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
        public double R{ get; set; }
        public double G { get; set; }
        public double B { get; set; }
    }
}
