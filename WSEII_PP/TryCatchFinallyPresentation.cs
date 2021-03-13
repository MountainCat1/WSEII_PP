using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WSEII_PP
{
    // 1. obsługa wyjątków (blok try-catch-finally)
    public static class TryCatchFinallyPresentation
    {
        public static void ReadFromFileIntoIntArray(string path, ref int[] array, int index) {
            StreamReader stream = new StreamReader(path);
            try {
                // spróbuj przeczytać plik do końca,
                // przekowertować tekst na liczbę,
                // a następnie wpisać ją do tablicy.
                // Mogą wydażyć się tu co najmniej 3 wyjątki

                string s = stream.ReadToEnd();
                array[index] = int.Parse(s);
                Console.WriteLine("Operacja wykonana pomyślnie");
            } catch (Exception ex) {
                // Jeżeli wyjątek wystąpi przechwytujemy go
                // aby uniknąć wysypania się programu

                ColorText.WriteError($"Przechwycono wyjątek: {ex.GetType()}");
            } finally {
                // Niezależnie czy uda się wykonać zadanie
                // strumień musi zostać zamknięty
                // więc stream.Close() umieszczam w finally{}

                if (stream != null)
                    stream.Close();
                Console.WriteLine($"Strumień zamknięty.");
            }
        }

        public static void Present(string path, ref int[] array, int index) {
            try {
                // W wypadku gdy ścieżka będzie nieodpowiednia
                // trzeba przechwycić wyjątek

                ReadFromFileIntoIntArray(path, ref array, index);
            } catch (FileNotFoundException ex) {
                // W wypadku gdy plik nie istnieje
                // dodatkowo wyświetl jego oczekiwaną lokalizacje

                ColorText.WriteError($"Przechwycono wyjątek: {ex.GetType()}");
                ColorText.WriteError($"Plik w lokacji {ex.FileName} nie istnieje!");
            } catch (Exception ex) {
                ColorText.WriteError($"Przechwycono wyjątek: {ex.GetType()}");
            }

            Console.WriteLine();
        }
    }


}
