using System;
using System.Linq;
using NUnit.Framework;

namespace Integration.Strava.Tests
{
    [TestFixture]
    public class TestIntegration
    {
        //[Ignore("Run manually")]
        [Test]
        public void GetActivities()
        {
            var service = new StravaService();

            var activities = service.GetActivities();
            
            Assert.NotNull(activities);
            Assert.That(activities.Any());
        }
    }
}