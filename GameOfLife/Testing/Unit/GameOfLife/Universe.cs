namespace GameOfLife.Testing.Unit
{
    public sealed class Universe
    {
        public bool[,] State { get; }

        public Universe(bool[,] seed)
        {
            State = seed;
        }
    }
}