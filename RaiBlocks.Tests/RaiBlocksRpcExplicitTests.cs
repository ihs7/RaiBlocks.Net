using NUnit.Framework;
using System.Threading.Tasks;
using RaiBlocks.ValueObjects;

namespace RaiBlocks.Tests
{
    [TestFixture, Explicit]
    public class RaiBlocksRpcExplicitTests
    {
        private RaiBlocksRpc _node = new RaiBlocksRpc("http://localhost:7076/");
        private RaiAddress _address = new RaiAddress("xrb_1q3hqecaw15cjt7thbtxu3pbzr1eihtzzpzxguoc37bj1wc5ffoh7w74gi6p");

        [Test]
        public async Task GetBalanceAsync()
        {
            var x = await _node.GetBalanceAsync(_address);
        }

        [Test]
        public async Task GetAccountBlockCount()
        {
            var x = await _node.GetAccountBlockCountAsync(_address);
        }

        [Test]
        public async Task GetAccountInformation()
        {
            var x = await _node.GetAccountInformationAsync(_address);
        }
    }
}
