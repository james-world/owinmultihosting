using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using NUnit.Framework;
using System.Net.Http;

namespace ApiTests
{
    public class ApiTests
    {
        private TestServer _server;

        [TestFixtureSetUp]
        public void FixtureInit()
        {
            _server = TestServer.Create<Api.Startup>();
        }

        [TestFixtureTearDown]
        public void FixtureDispose()
        {
            _server.Dispose();
        }

        [Test]
        public void TestGetAllValues()
        {
            var response = _server.HttpClient.GetAsync("/api/values").Result;
            var result = response.Content.ReadAsAsync<IEnumerable<string>>().Result;

            CollectionAssert.AreEqual(new [] {"value1", "value2"}, result);
        }
    }
}
