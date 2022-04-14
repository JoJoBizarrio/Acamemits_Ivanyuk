﻿namespace MinesweeperTask
{
    public class Minesweeper
    {
        public int[,] Field { get; set; }

        private Point[] MinesCoorditanes { get; set; }

        public int[,] LockedButtons { get; set; }

        public int MinutesCount { get; private set; }

        public int MinesCount { get; set; }

        public int SizeX { get; private set; }

        public int SizeY { get; private set; }

        public Minesweeper(int sizeX, int sizeY, int minesCount, int minutesCount)
        {
            Field = new int[sizeX, sizeY];
            LockedButtons = new int[sizeX, sizeY];
            MinesCoorditanes = new Point[minesCount];

            MinesCount = minesCount;
            MinutesCount = minutesCount;
            SizeX = sizeX;
            SizeY = sizeY;

            Random randomСoordinate = new Random();

            for (int i = 0; i < minesCount; ++i)
            {
                int randomСoordinateX = randomСoordinate.Next(sizeX);
                int randomСoordinateY = randomСoordinate.Next(sizeY);

                if (Field[randomСoordinateX, randomСoordinateY] >= 0)
                {
                    Field[randomСoordinateX, randomСoordinateY] = 9;

                    MinesCoorditanes[i] = new Point(randomСoordinateX, randomСoordinateY);
                }
                else
                {
                    --i;
                }
            }

            for (int i = 0; i < MinesCount; ++i)
            {
                int x = MinesCoorditanes[i].X;
                int y = MinesCoorditanes[i].Y;

                for (int j = x - 1; j <= x + 1; ++j)
                {
                    if (j < 0 || j >= sizeX)
                    {
                        continue;
                    }

                    for (int k = y - 1; k <= y + 1; ++k)
                    {
                        if (k < 0 || k >= sizeY)
                        {
                            continue;
                        }

                        if (Field[j, k] < 9)
                        {
                            Field[j, k] += 1;
                        }
                    }
                }
            }
        }
        
    }
}

//namespace SapperConsole
//{
//    public class Sapper
//    {
//        public static void OpenCell(int[,] array, int x, int y, int difficultyLevel)
//        {
//            if (array[x, y] == 0)
//            {
//                for (int i = -1; i <= 1; ++i)
//                {
//                    if (x + i < 0 || x + i >= difficultyLevel)
//                    {
//                        continue;
//                    }

//                    for (int j = -1; j <= 1; ++j)
//                    {
//                        if (y + j < 0 || y + j >= difficultyLevel)
//                        {
//                            continue;
//                        }

//                        //TODO: открыть array[x,y];
//                        OpenCell(array, x + i, y + j, difficultyLevel);
//                    }
//                }
//            }
//            else
//            {
//                //TODO: вызов открыть ячейку с числом
//                array[x, y] = 77;
//                return;
//            }
//        }

//        static void Main()
//        {
//            int easySize = 10;
//            int[,] array = new int[easySize, easySize];
//            int[,] minesCoorditanes = new int[easySize, 2];

//            Random random = new Random();

//            int randomX;
//            int randomY;

//            for (int i = 0; i < easySize; ++i)
//            {
//                randomX = random.Next(easySize);
//                randomY = random.Next(easySize);

//                if (array[randomX, randomY] >= 0)
//                {
//                    array[randomX, randomY] = -1;

//                    minesCoorditanes[i, 0] = randomX;
//                    minesCoorditanes[i, 1] = randomY;
//                }
//                else
//                {
//                    --i;
//                }
//            }

//            for (int i = 0; i < easySize; ++i)
//            {
//                for (int j = 0; j < easySize; ++j)
//                {
//                    Console.Write($"{array[i, j],5}");
//                }

//                Console.WriteLine();
//            }

//            int x;
//            int y;

//            for (int i = 0; i < easySize; ++i)
//            {
//                x = minesCoorditanes[i, 0];
//                y = minesCoorditanes[i, 1];

//                for (int j = -1; j <= 1; ++j)
//                {
//                    if (x + j < 0 || x + j >= easySize)
//                    {
//                        continue;
//                    }

//                    for (int k = -1; k <= 1; ++k)
//                    {
//                        if (y + k < 0 || y + k >= easySize)
//                        {
//                            continue;
//                        }

//                        if (array[x + j, y + k] >= 0)
//                        {
//                            array[x + j, y + k] += 1;
//                        }
//                    }
//                }
//            }

//            Console.WriteLine();

//            for (int i = 0; i < easySize; ++i)
//            {
//                for (int j = 0; j < easySize; ++j)
//                {
//                    Console.Write($"{array[i, j],5}");
//                }

//                Console.WriteLine();
//            }

//            OpenCell(array, 0, 0, easySize);

//            for (int i = 0; i < easySize; ++i)
//            {
//                for (int j = 0; j < easySize; ++j)
//                {
//                    Console.Write($"{array[i, j],5}");
//                }

//                Console.WriteLine();
//            }
//        }
//    }
//}