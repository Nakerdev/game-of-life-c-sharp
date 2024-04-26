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
        for(int rowIndex = 0; rowIndex < State.GetLength(0); rowIndex++) 
        {
            for(int cellIndex = 0; cellIndex < State.GetLength(1); cellIndex++) 
            {
                var cell = State[rowIndex, cellIndex];

                bool? rightNeighbour = cellIndex < State.GetLength(1) 
                    ? State[rowIndex, cellIndex + 1]
                    : null;
                bool? belowNeighbour = rowIndex < State.GetLength(0) 
                    ? State[rowIndex + 1, cellIndex]
                    : null;
                bool? rightBelowCornerNeighbour = rowIndex < State.GetLength(0) && cellIndex < State.GetLength(1) 
                    ? State[rowIndex + 1, cellIndex + 1]
                    : null;

                var liveNeighboursCounter = 0;
                if (rightNeighbour.HasValue && rightNeighbour.Value == true) ++liveNeighboursCounter;
                if (belowNeighbour.HasValue && belowNeighbour.Value == true) ++liveNeighboursCounter;
                if (rightBelowCornerNeighbour.HasValue && rightBelowCornerNeighbour.Value == true) ++liveNeighboursCounter;

                if (cell && liveNeighboursCounter < 2)
                {
                    State[rowIndex, cellIndex] = false;
                }
            }
        }
    }
}
