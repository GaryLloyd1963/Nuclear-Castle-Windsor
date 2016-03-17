using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nuclear.Tests.Unit
{
    [TestFixture]
    public class FacilityMonitorTests
    {
        [OneTimeSetUp]
        public void SetupFacilityMonitor()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
