using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DKRender.UnitTests.Engine.Types.Vector
{
    [TestClass]
    public class Normalize
    {
        [TestMethod]
        public void CanNormalize()
        {
            var vector = new DKRender.Engine.Types.Vector(3, 1, 2);
            vector.Normalize();

            Assert.AreEqual(0.80178372573727319, vector.X);
            Assert.AreEqual(0.2672612419124244, vector.Y);
            Assert.AreEqual(0.53452248382484879, vector.Z);
        }
    }
}
