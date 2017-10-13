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
        }
    }
}
