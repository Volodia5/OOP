using System;
using System.Collections.Generic;
using System.Threading;

namespace ScreensaverFromTheMatrix
{
    class ManagerElementsMatrix
    {
        private List<ElementMatrix> _elementMatrixes;
        private Random random;
        private char _randomSymbolMatrix;
        private ConsoleColor _consoleColor;
        private int _colorIndex;
        private int xMin, yMin, xMax, yMax;

        public ManagerElementsMatrix()
        {
            _elementMatrixes = new List<ElementMatrix>();
            random = new Random();

            xMin = 1;
            xMax = Console.WindowWidth - 1;

            yMin = 1;
            yMax = Console.WindowHeight - 1;
        }

        public void AddElementMatrix(int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(xMin , xMax);
                int y = random.Next(yMin, yMax);
                _randomSymbolMatrix = (char) random.Next('a', 'z' + 1);
                _colorIndex = random.Next(1, 2 + 1);
                if (_colorIndex == 1)
                {
                    _consoleColor = ConsoleColor.Green;
                }
                else if (_colorIndex == 2)
                {
                    _consoleColor = ConsoleColor.Yellow;
                }
                ElementMatrix elementMatrix = new ElementMatrix(x, y, _randomSymbolMatrix, _consoleColor);

                _elementMatrixes.Add(elementMatrix);
            }
        }

        public void FallElementMatrix()
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < _elementMatrixes.Count; i++)
                {
                    _elementMatrixes[i].FallElement(yMin, yMax);
                }

                for (int i = 0; i < _elementMatrixes.Count; i++)
                {
                    _elementMatrixes[i].ShowElementMatrix();
                }

                Thread.Sleep(300);
            }
        }
    }
}
