using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monkeys;
using System.Collections.Generic;

namespace MonkeyTests
{
    [TestClass]
    public class BridgeTest
    {
        [TestMethod]
        public void LeftStartHasMonkeys()
        {
            Bridge bridge = new Bridge
            {
                LeftStart = new List<Monkey>
                {
                    new Monkey { Id = 1, Name = "Brown" },
                    new Monkey { Id = 2, Name = "Yiper" },
                    new Monkey { Id = 3, Name = "Smive" }
                }
            };

            Assert.AreEqual(3, bridge.LeftStart.Count);
            Assert.AreEqual("Brown", bridge.LeftStart[0].Name);
            Assert.AreEqual("Yiper", bridge.LeftStart[1].Name);
            Assert.AreEqual("Smive", bridge.LeftStart[2].Name);
        }

        [TestMethod]
        public void RightStartHasMonkeys()
        {
            Bridge bridge = new Bridge
            {
                LeftStart = new List<Monkey>
                {
                    new Monkey { Id = 1, Name = "Green" },
                    new Monkey { Id = 2, Name = "Albert" },
                    new Monkey { Id = 3, Name = "Sylie" }
                }
            };

            Assert.AreEqual(3, bridge.LeftStart.Count);
            Assert.AreEqual("Green", bridge.LeftStart[0].Name);
            Assert.AreEqual("Albert", bridge.LeftStart[1].Name);
            Assert.AreEqual("Sylie", bridge.LeftStart[2].Name);
        }

        [TestMethod]
        public void CrossLeftMonkeys()
        {
            Bridge bridge = new Bridge
            {
                LeftStart = new List<Monkey>
                {
                    new Monkey { Id = 1, Name = "Brown" },
                    new Monkey { Id = 2, Name = "Yiper" },
                    new Monkey { Id = 3, Name = "Smive" }
                }
            };

            Assert.AreEqual(3, bridge.LeftStart.Count);

            bridge.CrossTheBridge(bridge.LeftStart, bridge.RightStart);

            Assert.AreEqual(0, bridge.LeftStart.Count);
            Assert.AreEqual(3, bridge.RightEnd.Count);
            Assert.AreEqual("Brown", bridge.RightEnd[0].Name);
            Assert.AreEqual("Yiper", bridge.RightEnd[1].Name);
            Assert.AreEqual("Smive", bridge.RightEnd[2].Name);
        }
    }
}
