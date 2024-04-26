using FluentAssertions;

namespace GameOfLife.Testing.Unit
{
    [TestFixture]
    public sealed class GameTests
    {
        [Test]
        public void ShouldCreatesUniverseWithInitialState() 
        {
            bool[,] seed = 
            { 
                { false, false, false, false },
                { false, false, false, false }, 
                { false, false, false, false },
                { false, false, false, false } 
            };

            var universe = new Universe(seed);

            universe.State.Should().Be(seed);
        }
    }
}
