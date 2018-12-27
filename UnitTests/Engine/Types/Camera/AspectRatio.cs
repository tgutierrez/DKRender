using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DKRender.UnitTests.Engine.Types.Camera
{
    [TestClass]
    public class AspectRatio
    {
        [TestMethod]
        public void CanComputeAspectRatio()
        {
            var camera = new DKRender.Engine.Types.Camera(640, 480, 30);

            Assert.AreEqual(4.0/3.0, camera.AspectRatio);
        }
    }
}
