using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DKRender.UnitTests.Engine.Types.Camera
{
    [TestClass]
    public class Angle
    {
        [TestMethod]
        public void CanComputeAngle()
        {
            var camera = new DKRender.Engine.Types.Camera(640, 480, 30);
            Assert.AreEqual(0.2679491924311227, camera.Angle);
        }
    }
}
