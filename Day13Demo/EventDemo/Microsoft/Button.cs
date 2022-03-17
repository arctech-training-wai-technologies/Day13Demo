using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo.EventDemo.Microsoft
{
    public class Button
    {
        private string _text;
        private int _left, _top;
        private ConsoleColor foreColor, backColor;

        public char Key { get; }

        public Button(string text, int left, int top, char key)
        {
            _text = text;
            _left = left;
            _top = top;
            Key = key;

            foreColor = ConsoleColor.Black;
            backColor = ConsoleColor.White;
        }


        public void Show()
        {
            Console.SetCursorPosition(_left, _top);
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;

            Console.Write(_text);

            Console.ResetColor();
        }

        internal void AdjustPosition(int left, int top)
        {
            _left += left;
            _top += top;
        }

        internal void Click()
        {
            Console.SetCursorPosition(_left, _top);
            Console.ForegroundColor = backColor;
            Console.BackgroundColor = foreColor;

            Console.Write(_text);
            Thread.Sleep(100);

            Console.ResetColor();

            Show();
        }

        public void Hide()
        {
            Console.SetCursorPosition(_left, _top);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write(_text);

            Console.ResetColor();
        }
    }
}
