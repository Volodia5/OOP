using System;

namespace ScreensaverFromTheMatrix
{
    class ElementMatrix
    {
        private int _x, _y;
        private char _symbol;
        private ConsoleColor _consoleColor;

        public ElementMatrix(int x, int y, char symbol, ConsoleColor consoleColor)
        {
            _x = x;
            _y = y;
            _symbol = symbol;
            _consoleColor = consoleColor;
        }

        public void ShowElementMatrix()
        {
            Console.ForegroundColor = _consoleColor;
            Console.SetCursorPosition(_x, _y);
            Console.Write(_symbol);
        }

        public void FallElement(int yMin, int yMax)
        {
            _y++;
            if(_y > yMax)
            {
                _y = yMin;
            }
        }
    }
}
