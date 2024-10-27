public class ConsoleMenu
{
    private List<string> _menuItems;
    private int _selectedIndex;

    public ConsoleMenu(List<string> menuItems)
    {
        _menuItems = menuItems;
        _selectedIndex = 0;
    }

    public string DisplayMenu()
    {
        Console.CursorVisible = false;
        while (true)
        {
            int itemsPerColumn = Console.WindowHeight - 2;
            // int numColumns = (int)Math.Ceiling((double)_menuItems.Count / itemsPerColumn);
            int columnWidth = 20;

            for (int i = 0; i < _menuItems.Count; i++)
            {
                int column = i / itemsPerColumn;
                int row = i % itemsPerColumn;

                Console.SetCursorPosition(column * columnWidth, row + 1);

                if (i == _selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                // Console.WriteLine("TESTING");
                Console.Write(_menuItems[i].PadRight(columnWidth));

                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    _selectedIndex = (_selectedIndex - 1 + _menuItems.Count) % _menuItems.Count;
                    break;
                case ConsoleKey.DownArrow:
                    _selectedIndex = (_selectedIndex + 1) % _menuItems.Count;
                    break;
                case ConsoleKey.LeftArrow:
                    _selectedIndex = Math.Max(0, _selectedIndex - itemsPerColumn);
                    break;
                case ConsoleKey.RightArrow:
                    _selectedIndex = Math.Min(_menuItems.Count - 1, _selectedIndex + itemsPerColumn);
                    break;
                case ConsoleKey.Enter:
                    return _menuItems[_selectedIndex];
            }
        }
    }
}