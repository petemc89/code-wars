using System.Collections.Generic;

namespace SnailSort
{
    public static class Kata
    {
        private enum Direction
        {
            Down,
            Left,
            Up,
            Right
        }

        public static int[] Snail(int[][] array)
        {
            // For an n*n array, the number of "lines" in the snail is equal to n*2-1
            int lines = array.Length * 2 - 1;

            // Results List. The first line is always the whole first array
            List<int> sortedList = new List<int>();
            sortedList.AddRange(array[0]);

            // Starting coordinates & direction
            int lineLength = array.Length - 1;
            int x = 1;
            int y = array.Length - 1;
            Direction? direction = Direction.Down;

            for (var i = 0; i < lines; i++)
            {
                for (var j = 0; j < lineLength; j++)
                {
                    int num = array[x][y];
                    sortedList.Add(num);

                    // This is equivalent to checking that the line has been traversed the required number of times
                    if (j + 1 == lineLength)
                    {
                        direction = direction.Next();

                        // Every 2 lines, the length of the next 2 lines is reduced by 1
                        if ((i + 1) % 2 == 0) { lineLength--; }
                    }

                    x = x.NextX(direction);
                    y = y.NextY(direction);
                }
            }

            return sortedList.ToArray();
        }

        private static Direction? Next(this Direction? currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.Down:
                    return Direction.Left;
                case Direction.Left:
                    return Direction.Up;
                case Direction.Up:
                    return Direction.Right;
                case Direction.Right:
                    return Direction.Down;
                default:
                    return null;
            }
        }

        private static int NextX(this int currentX, Direction? currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.Down:
                    return currentX + 1;
                case Direction.Up:
                    return currentX - 1;
                default:
                    return currentX;
            }
        }

        private static int NextY(this int currentX, Direction? currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.Right:
                    return currentX + 1;
                case Direction.Left:
                    return currentX - 1;
                default:
                    return currentX;
            }
        }
    }
}
