using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Demo.EventDemo.Microsoft
{
    public class Window
    {
        private string _titleText;
        int _left, _top, _width, _height;
        private readonly List<Button> buttons;

        public Window(string titleText, int left, int top, int width, int height)
        {
            buttons = new List<Button>();

            _titleText = titleText;
            _left = left;
            _top = top;
            _width = width;
            _height = height;
        }

        internal void WaitForButtonClick()
        {
            while (true)
            {
                var buttonCliked = false;
                var keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                    return;

                foreach(var button in buttons)
                {
                    if(button.Key == keyInfo.KeyChar)
                    {
                        button.Click();
                        buttonCliked = true;
                        break;
                    }
                }

                if(!buttonCliked)
                    Console.Beep();
            }
        }

        public void AddButton(Button button)
        {
            button.AdjustPosition(_left, _top);
            buttons.Add(button);
        }

        public void Show()
        {
            var bottomLine = new string('-', _width);
            var topLine = $"= {_titleText} {new string('=', _width - _titleText.Length - 3)}";

            var rowLine = $"|{new string(' ', _width - 2)}|";

            Console.SetCursorPosition(_left, _top);
            Console.WriteLine(topLine);

            for (int row = 1; row < _height - 1; row++)
            {
                Console.SetCursorPosition(_left, _top + row);
                Console.WriteLine(rowLine);
            }
            Console.SetCursorPosition(_left, _top + _height - 1);
            Console.WriteLine(bottomLine);

            foreach (var button in buttons)
            {
                button.Show();
            }
        }
    }
}
