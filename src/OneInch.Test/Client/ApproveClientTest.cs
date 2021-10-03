using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net.Http;
using System;

using OneInch.Api;

namespace OneInch.Test
{
    [TestClass]
    public class ApproveClientTest
    {
        [TestMethod]
        public void ArgumentsNotNull()
        {
            var mockFactory = new Mock<IApiAdapter>();
            IApiAdapter factory = mockFactory.Object;
            var api = new ApproveClient(factory);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentsNull_IApiAdapter()
        {
            var api = new ApproveClient(null);
        }
    }
}
