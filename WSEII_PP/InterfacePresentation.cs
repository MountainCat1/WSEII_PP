using System;
using System.Collections.Generic;
using System.Text;

namespace WSEII_PP
{
    // 3. --klasy, dziedziczenie,-- interfejsy


    public static class InterfacePresentation
    {
        interface IInterface // deklaracja interfejsu
        {
            public void PrintVariable();
        }
        class ClassA : IInterface // Klasa ClassA dziedziczy interfejs IInterface
                                  // co wymusza na niej implementowanie metody void PrintVariable()
        {
            public int someFunnyVariable = 6;

            void IInterface.PrintVariable() {
                Console.Write(someFunnyVariable);
            }
        }
        class ClassB : IInterface // Klasa ClassB tak samo jak klasa ClassA dziedziczy
                                            // interfejs IInterface co wymusza na niej implementowanie
                                            // metody void PrintVariable()
        {
            public char someLessFunnyVariable = 'u';

            void IInterface.PrintVariable() {
                Console.Write(someLessFunnyVariable);
            }
        }
        public static void Present() {
            ClassA objectA = new ClassA();
            ClassB objectB = new ClassB();

            List<IInterface> list = new List<IInterface>();
            list.Add(objectB); 
            list.Add(objectA); // Pomimo tego, że obiekty objectA i objectB są stworzone
                               // na podstawie innych klas oraz nie dziedziczą z tej samej klasy
                               // dzięki temu, ze dziedziczą z tego samego interfejsu
                               // można je rzutować na jeden typ

            foreach (IInterface item in list) {
                Console.Write($"{item.GetType().Name} prints value: ");
                item.PrintVariable();
                Console.WriteLine();
            }
            // Dzięki użyciu interfejsu można było wypisać w jednej pętli zmienne obiektów dwóch różnych klas
        }
    }
}
