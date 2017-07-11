using NUnit.Framework;
using Slooce.NET.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slooce.NET.Test
{

    [Category("Slooce")]
    [TestFixture]
    public class SlooceTest
    {

        private static readonly string slooceUrl = Environment.GetEnvironmentVariable("SLOOCE_URL");
        private static readonly string sloocePassword = Environment.GetEnvironmentVariable("SLOOCE_PWD");
        private static readonly string slooceNumber = Environment.GetEnvironmentVariable("SLOOCE_NUM");
        private static readonly string slooceKeyword = Environment.GetEnvironmentVariable("SLOOCE_KEYWORD");

        private SlooceApi api;

        [OneTimeSetUp]
        public void Setup()
        {
            api = new SlooceApi(new SlooceConfig(
                slooceUrl,
                sloocePassword));
        }

        [Test]
        public async Task CheckEligibility()
        {
            var resp = await api.CheckUserEligibilityAsync(slooceNumber, slooceKeyword);
            Assert.AreEqual(resp.Result, UserEligibilityResponseResult.Supported);
        }

        [Test]
        public async Task RegisterUser()
        {
            var resp = await api.RegisterUserAsync(slooceNumber, slooceKeyword);
            Assert.AreEqual(resp.Result, UserRegisterResponseResult.Ok);
        }

        [Test]
        public async Task SendText()
        {
            var resp = await api.SendMtMessageAsync(slooceNumber, slooceKeyword, "Test message.");
            Assert.AreEqual(resp.Result, MTResponseResult.Ok);
        }

        [Test]
        public async Task CheckOperator()
        {
            var resp = await api.CheckOperatorAsync(slooceNumber);
            Assert.AreEqual(resp.Operator, Operator.ATT);
        }

    }
}
