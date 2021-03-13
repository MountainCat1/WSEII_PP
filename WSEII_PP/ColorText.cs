using System;
using System.Collections.Generic;
using System.Text;

namespace WSEII_PP
{
    public static class ColorText
    {
        public static void WriteInColor(ConsoleColor color, params object[] _message) {
            string message = "";
            foreach (var item in _message) {
                message += item.ToString();
            }
            ConsoleColor _color = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = _color;
        }
        public static void WriteError(params object[] _message) {
            string message = "";
            foreach (var item in _message) {
                message += item.ToString();
            }
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR: " + message);
            Console.ForegroundColor = color;
        }
    }
}
