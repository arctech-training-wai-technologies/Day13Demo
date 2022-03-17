// See https://aka.ms/new-console-template for more information

using Day13Demo;
using Day13Demo.EventDemo.Microsoft;

//DelegateDemo.Test();
//DelegateDemo2.Test();

//Button b1 = new Button("Save", 10, 10);
//b1.Show();

//Button b2 = new Button("Cancel", 20, 10);
//b2.Show();

Console.Clear();

Window w = new Window("Notepad", 10, 3, 40, 8);

w.AddButton(new Button("Save", 2, 6, 's'));
w.AddButton(new Button("Cancel", 8, 6, 'c'));
w.AddButton(new Button("Next", 16, 6, 'n'));
w.AddButton(new Button("Previous", 22, 6, 'p'));

w.Show();
w.WaitForButtonClick();


