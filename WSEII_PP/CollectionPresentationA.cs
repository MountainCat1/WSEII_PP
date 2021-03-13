using System;
using System.Collections.Generic;

namespace WSEII_PP
{
    // 4. kolekcje: List<T>, Queue<T>, Stack<T>

    public partial class CollectionPresentation
    {
        public class TestClass
        {
            public string variable = "default state";

            public TestClass(string variable) {
                this.variable = variable;
            }
        }

        public static void Present() {
            Console.ReadKey(); PresentList();
            Console.ReadKey(); PresentQueue();
            Console.ReadKey(); PresentStack();
            Console.ReadKey(); PresentSortedList();
            Console.ReadKey(); PresentDictionary();
        }

        static void PresentList() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "= List =\n"); // lista to kolekcja zdolna do przechwywania
                                             // danych z możliwością rozszerzeania się w przypadku takiej potrzeby
                                             // lista zapewnia pełny dostęp do wszystkich swoich elementów

            List<TestClass> list = new List<TestClass>();
            list.Add(new TestClass("cats")); Console.WriteLine("Added object to list...");
            list.Add(new TestClass("dogs")); Console.WriteLine("Added object to list...");
            list.Add(new TestClass("goats")); Console.WriteLine("Added object to list...");

            Console.WriteLine($"\nList length = {list.Count}\n");

            list.Add(new TestClass("snakes")); Console.WriteLine("Added object to list...");
            list.Add(new TestClass("birds")); Console.WriteLine("Added object to list...");

            Console.WriteLine($"\nList length = {list.Count}\n");

            list.RemoveAt(1); Console.WriteLine("Removed object with index 1...");
            list[3] = new TestClass("lizards"); Console.WriteLine("Changed object with index 0...");

            Console.WriteLine($"\nList length = {list.Count}\n");

            Console.WriteLine("Printing list: ");
            foreach (var item in list) {        // foreach działa na liście dzięki temu,
                                                // że ta dziedziczy z IEnumerable
                Console.WriteLine("\t" + item.variable);
            }
            Console.WriteLine();
        }
    
        static void PresentQueue() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "= Queue =\n"); // kolejka to kolekcja zdolna do przechwywania
                                             // danych z możliwością rozszerzeania się w przypadku takiej potrzeby
                                             // kolejka pozwala na wykolejkowanie najwcześniej zakolejkowanego 
                                             // elementu -- nie można wybierać z niej elementów po indeksie

            Queue<TestClass> queue = new Queue<TestClass>();
            queue.Enqueue(new TestClass("cats")); Console.WriteLine("Enqueued object to queue...");
            queue.Enqueue(new TestClass("dogs")); Console.WriteLine("Enqueued object to queue...");
            queue.Enqueue(new TestClass("lizards")); Console.WriteLine("Enqueued object to queue...");
            queue.Enqueue(new TestClass("snakes")); Console.WriteLine("Enqueued object to queue...");

            Console.WriteLine($"\nQueue length = {queue.Count}\n");


            Console.WriteLine("Printing queue: ");
            foreach (var item in queue) {        // foreach działa na kolejce dzięki temu,
                                                 // że ta dziedziczy z IEnumerable
                Console.WriteLine("\t" + item.variable);
            }
            Console.WriteLine();

            TestClass testObject = queue.Dequeue(); Console.WriteLine($"Dequeued from queue... {testObject.variable}");
                // fukcja Dequeue() wyciąga z kolejki najwcześniej
                // zakolejkowany element jednocześnie usuwając go
                // z kolejki
            testObject = queue.Peek(); Console.WriteLine($"Peeked to queue... {testObject.variable}");
                // fukcja Peek() zwraca z kolejki najwcześniej
                // zakolejkowany element jednocześnie NIE usuwając go
                // z kolejki

            Console.WriteLine($"\nQueue length = {queue.Count}\n");


            Console.WriteLine("Printing queue: ");
            foreach (var item in queue) {        // foreach działa na kolejce dzięki temu,
                                                 // że ta dziedziczy z IEnumerable
                Console.WriteLine("\t" + item.variable);
            }
            Console.WriteLine();
        }
        
        static void PresentStack() {
            ColorText.WriteInColor(ConsoleColor.Cyan, "= Stack =\n"); // stos to kolekcja zdolna do przechwywania
                                                                      // danych z możliwością rozszerzeania się w przypadku takiej potrzeby
                                                                      // stos pozwala na wyłuskanie najpóźniej wepchanego 
                                                                      // elementu -- nie można wybierać z niego elementu po indeksie

            Stack<TestClass> stack = new Stack<TestClass>();
            stack.Push(new TestClass("cats"));      Console.WriteLine("Pushed object on top of stack...");
            stack.Push(new TestClass("dogs"));      Console.WriteLine("Pushed object on top of stack...");
            stack.Push(new TestClass("lizards"));   Console.WriteLine("Pushed object on top of stack...");
            stack.Push(new TestClass("snakes"));    Console.WriteLine("Pushed object on top of stack...");

            Console.WriteLine($"\nStack length = {stack.Count}\n");

            Console.WriteLine("Printing stack: ");
            foreach (var item in stack) {        // foreach działa na stosie dzięki temu,
                                                 // że ten dziedziczy z IEnumerable
                Console.WriteLine("\t" + item.variable);
            } 
            Console.WriteLine();


            TestClass testObject = stack.Pop(); Console.WriteLine($"Poped from stack... {testObject.variable}");
            // fukcja Pop() wyciąga ze stosu najpóźniej
            // wepchnięty element jednocześnie usuwając go
            // ze stosu
            testObject = stack.Peek(); Console.WriteLine($"Peeked to stack... {testObject.variable}");
            // fukcja Peek() wyciąga ze stosu najpóźniej
            // wepchnięty element jednocześnie NIE usuwając go
            // ze stosu

            Console.WriteLine($"\nStack length = {stack.Count}\n");


            Console.WriteLine("Printing stack: ");
            foreach (var item in stack) {        // foreach działa na stosie dzięki temu,
                                                 // że ten dziedziczy z IEnumerable
                Console.WriteLine("\t" + item.variable);
            }
            Console.WriteLine();
        }
    }
}