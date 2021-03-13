using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/*
        1. obsługa wyjątków (blok try-catch-finally)
        2. funkcje, w szczególności przesyłanie parametrów przez wartość i przez referencję
        3. klasy, dziedziczenie, interfejsy
        4. kolekcje: List<T>, Queue<T>, Stack<T>
        5. kolekcje: SortedList<K, V>, Dictionary<K, V>
*/

namespace WSEII_PP
{
    class Program
    {
        public static void Main() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "==== Try Catch Finally ====\n");
            int[] array = new int[10];
            TryCatchFinallyPresentation.Present("datadasdasdsadsadsada.txt", ref array, 5);
            TryCatchFinallyPresentation.Present("data.txt", ref array, 15);
            TryCatchFinallyPresentation.Present("data.txt", ref array, 5);
            Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== Functions, parameters and references ====\n");
            FunctionsPresentation.Present();
            Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== Classes and inheritance ====\n");
            ObjectsPresentation.Present();
            Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== Interfaces ====\n");
            InterfacePresentation.Present();
            Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== List<T> Queue<T> Stack<T> ====\n");
            CollectionPresentation.Present();
            //Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== List<T> Queue<T> Stack<T> ====\n");
            CollectionPresentation.Present();
            Console.ReadKey();

            ColorText.WriteInColor(ConsoleColor.Cyan, "\n==== Koniec prezentacji ====\n");
            Console.ReadKey();
        }

        public static void DisplaySortedList<K, V>(SortedList<K, V> SL) {
            foreach(var item in SL) {
                Console.WriteLine($"{item.Key}");
            }
            Console.WriteLine();
        }
        public static void DisplayIEnumerable(IEnumerable IE) {
            foreach (var item in IE) {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}

