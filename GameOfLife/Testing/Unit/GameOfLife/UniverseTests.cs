using FluentAssertions;
using NUnit.Framework;

namespace GameOfLife;

[TestFixture]
public sealed class UniverseTests
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

    [Test]
    public void NextGenerationFromADeathUniverseWillStillDeath()
    {
        bool[,] seed =
        {
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        var universe = new Universe(seed);

        universe.NextGen();

        universe.State.Should().BeEquivalentTo(seed);
    }

    [Test]
    public void NextGenerationFromAUniverseWithOnlyOneCellWillBeDeath()
    {
        bool[,] seed =
        {
            { true, false, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        var universe = new Universe(seed);

        universe.NextGen();

        bool[,] nextGeneration =
        {
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        universe.State.Should().BeEquivalentTo(nextGeneration);
    }

    [Test]
    public void NextGenerationACellWithLessThanTwoLiveNeighboursDies()
    {
        bool[,] seed =
        {
            { true, true, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        var universe = new Universe(seed);

        universe.NextGen();

        bool[,] nextGeneration =
        {
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        universe.State.Should().BeEquivalentTo(nextGeneration);
    }
}
