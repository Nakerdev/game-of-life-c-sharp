using FluentAssertions;
using NUnit.Framework;

namespace GameOfLife.Testing.Unit
{
    [TestFixture]
    public sealed class GameTests
    {
        [Test]
        public void TrueShouldBeTrue() 
        {
            true.Should().BeTrue();
        }
    }
}
