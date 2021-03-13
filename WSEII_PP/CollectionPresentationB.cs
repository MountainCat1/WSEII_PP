using System;
using System.Collections.Generic;
using System.Text;

namespace WSEII_PP
{        
    // 5. kolekcje: SortedList<K, V>, Dictionary<K, V>
    public partial class CollectionPresentation
    {
        public static void PresentSortedList() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "= Sorted List =\n"); // posortowana lista jest kolekcją przyjmującą dwa
                                                                            // argumenty -- przerwszy jest kluczem który musi
                                                                            // dziedziczyć interfejsc ICompareable, to po nim owa lista
                                                                            // automatycznie się sortuje po dodaniu/zmienieniu
                                                                            // dowolniej wartości klucza

            SortedList<string, TestClass> SL = new SortedList<string, TestClass>();     // w tym wypadku lista będzie posortowana
                                                                                        // na podstawie wartości TestClass.variable

            AddTestClassOjectToSortedList(new TestClass("cats"), SL); Console.WriteLine("Added object to sorted list");
            AddTestClassOjectToSortedList(new TestClass("dogs"), SL); Console.WriteLine("Added object to sorted list");
            AddTestClassOjectToSortedList(new TestClass("lizards"), SL); Console.WriteLine("Added object to sorted list");
            AddTestClassOjectToSortedList(new TestClass("snakes"), SL); Console.WriteLine("Added object to sorted list");

            Console.WriteLine($"\nSorted List length = {SL.Count}\n");

            Console.WriteLine("Printing list: ");
            foreach (var item in SL) {        // foreach działa na posortowanej liście dzięki temu,
                                              // że ta dziedziczy z IEnumerable
                Console.WriteLine($"\t{item.Key}");
            }

            SL.RemoveAt(3); Console.WriteLine("Removed object from sorted list with index 3");
            AddTestClassOjectToSortedList(new TestClass("goats"), SL); Console.WriteLine("Added object to sorted list");

            Console.WriteLine($"\nStack length = {SL.Count}\n");

            Console.WriteLine("Printing list: ");
            foreach (var item in SL) {  
                Console.WriteLine($"\t{item.Key}");
            }

            // Pomimo zmian w liście ta nadal będzie posortowana względem klucza
        }

        public static void PresentDictionary() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "= Dictionary =\n");  // słownik jest kolekcją przyjmującą dwa
                                                                            // argumenty -- przerwszy jest kluczem, a drugi wartością
                                                                            // klucze muszą być unikatowe
                                                                            // w razie potrzeby sam automatycznie się powiększa

            Dictionary<TestClass, int> dictionary = new Dictionary<TestClass, int>();     // w tym wypadku lista będzie posortowana
                                                                                          // na podstawie wartości TestClass.variable
            TestClass testObject = new TestClass("lizards");
            dictionary.Add(new TestClass("cats"), 5);    Console.WriteLine("Added KeyPairValue to dictionary...");
            dictionary.Add(new TestClass("dogs"), 9);    Console.WriteLine("Added KeyPairValue to dictionary...");
            dictionary.Add(testObject, 2); Console.WriteLine("Added KeyPairValue to dictionary...");
            dictionary.Add(new TestClass("snakes"), 4);  Console.WriteLine("Added KeyPairValue to dictionary...");

            Console.WriteLine($"\nDictionary length = {dictionary.Count}\n");

            Console.WriteLine("Printing dicionary: ");
            foreach (var item in dictionary) {        // foreach działa na słowniku dzięki temu,
                                                      // że ten dziedziczy z IEnumerable
                Console.WriteLine($"\t Key: {item.Key.variable} \t| Value {item.Value}");
            }

            dictionary.Add(new TestClass("goats"), 9);      Console.WriteLine("AddedKeyPairValue to dictionary...");
            // Wartości mogą się powtarzać w przeciwieństwie do kluczy


            dictionary.Add(new TestClass("cows"), 12); Console.WriteLine("AddedKeyPairValue to dictionary...");
            dictionary.Remove(testObject);                  Console.WriteLine("Removed KeyPairValue from dictionary...");

            Console.WriteLine($"\nDictionary length = {dictionary.Count}\n");

            Console.WriteLine("Printing dicionary: ");
            foreach (var item in dictionary) {        
                Console.WriteLine($"\t Key: {item.Key.variable} \t| Value {item.Value}");
            }
        }


        static void AddTestClassOjectToSortedList(TestClass testClassObject, SortedList<string, TestClass> SL) {
            SL.Add(testClassObject.variable, testClassObject);
        }


    }

}
