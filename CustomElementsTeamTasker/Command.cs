using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomElementsTeamTasker
{
    public class Command
    {
        private static RoutedUICommand clear;
        static Command()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R,ModifierKeys.Control,"Ctrl+R"));
            clear = new RoutedUICommand("Clear", "Clear", typeof(Command), inputs);
        }
        public static RoutedUICommand Clear
        {
            get { return clear; }
        }
    }
}
