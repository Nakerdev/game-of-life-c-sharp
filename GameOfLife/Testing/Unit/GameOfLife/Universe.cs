namespace GameOfLife;

public sealed class Universe
{
    public bool[,] State { get; private set; }

    public Universe(bool[,] seed)
    {
        State = seed;
    }

    public void NextGen()
    {
        bool[,] nextGeneration =
        {
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false },
            { false, false, false, false }
        };
        State = nextGeneration;
    }
}
