using System;
using DKRender.Base;
using Rhino.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DKRender.UnitTests.Engine
{
    [TestClass]
    public class Render
    {
        Rhino.Mocks.MockRepository _mocks;

        [TestInitialize]
        public void Init() {
            _mocks = new Rhino.Mocks.MockRepository();
        }

        [TestCleanup]
        public void Cleanum() {
            _mocks.VerifyAll();
        }


        [TestMethod]
        public void CanRenderSomething()
        {
            // Setup
            var testScene = CreateTestScene();
            // Mock
            var renderer = _mocks.PartialMock<DKRender.Engine.Engine>();

            renderer.Expect(r => r.Trace(Arg<DKRender.Engine.Types.Vector>.Is.Anything,
                                         Arg<DKRender.Engine.Types.Vector>.Is.Anything,
                                         Arg<IEnumerable<IGeometryObject>>.Is.Anything,
                                         Arg<int>.Is.Equal(0))).Return(new DKRender.Engine.Types.Pixel()).Repeat.Times(4);
            // Execute
            _mocks.ReplayAll();
            var image = renderer.Render(testScene);
            
            // Assert
            // It should output a 4x4 image....
            Assert.AreEqual(4, image.Canvas.Length);
        }

        private IScene CreateTestScene()
        {
            return new DKRender.Engine.Types.Scene(new DKRender.Engine.Types.Camera(2, 2, 30));
        }
    }
}
