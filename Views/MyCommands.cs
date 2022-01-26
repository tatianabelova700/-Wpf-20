using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab20___WpfApp
{
    class MyCommands
    {
        public static RoutedUICommand Exit { get; set; }
        public static RoutedUICommand TopDark { get; set; }
        public static RoutedUICommand TopLight { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputsExit = new InputGestureCollection();
            inputsExit.Add(new KeyGesture(Key.Q, ModifierKeys.Control, "Ctrl+Q"));
            Exit = new RoutedUICommand("_Выход", "Exit", typeof(MyCommands), inputsExit);

            TopLight = new RoutedUICommand("_Светлая тема", "TopLight", typeof(MyCommands));

            TopDark = new RoutedUICommand("_Темная тема", "TopDark", typeof(MyCommands));
        }
    }
}
