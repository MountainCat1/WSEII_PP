using System;
using System.Collections.Generic;
using System.Text;

namespace WSEII_PP
{
    // 3. klasy, dziedziczenie, --interfejsy--

    public static class ObjectsPresentation
    {
        abstract class Parent // klasa abstrakcyjna -- tzn nie da się tworzyć obiektów
                              // na jej podstawie, ale można ją dziedziczyć
        {
            public string name;
            public virtual void ParentMethod() { // wirtualne metody/funkcje można nadpisać w klasach dziedziczących,
                                                 // w przeciwieństwie do abstrakcyjnych które TRZEBA nadpisać
                Console.WriteLine($"{GetType().Name} used ParentMethod()");
            }

            public abstract void ParentAbstractMethod(); // Funckcja abstrakcyjna nie ma "ciała"
                                                         // ponieważ istnieje po to aby być nadpisana
        }

        class ChildA : Parent // klasa dziedzicząca z klasy Parent
        {
            public int intigerVaraible;

            public override void ParentMethod() {
                base.ParentMethod();
                Console.WriteLine("But also there is something more!");
            }
            public override void ParentAbstractMethod() {
                Console.WriteLine($"{GetType().Name}   I was forced to override this method!");
            }
        }

        class ChildB : Parent // klasa dziedzicząca z klasy Parent
        {
            public string stringVariable;
            public override void ParentAbstractMethod() {
                Console.WriteLine($"{GetType().Name}   You always has to override abstract methods!");
            }
        }

        public static void Present() {
            ChildA objectA = new ChildA();
            objectA.name = "Value"; // Pomimo tego, że w klasie ChildA nie
                                    // zdeklarowano zmiennej name,
                                    // jest ona dziedziczona z klasy Parent
            objectA.intigerVaraible = 6;

            ChildB objectB = new ChildB();
            objectB.name = "Funny Value";
            objectB.stringVariable = "Only my variable";

            List<Parent> list = new List<Parent>();

            list.Add(objectA);
            list.Add(objectB); // Dzięki temu, że ChildA oraz ChildB dziedziczą z tej samej klasy
                               // mogą być na nią rzutowane dzięki czemu możliwe jest umieszczenie
                               // obiektów różnych klas w jednej liście
                               // ogarniczeniem jedank jest to, że po rzutowaniu można używać tylko
                               // metod, zmiennych... itp wspólnych -- tzn. należąccych do klasy Parent

            Console.WriteLine("Nazwy obiektów: ");
            foreach (Parent item in list) {
                Console.WriteLine($"{item.GetType().Name}     name = {item.name}");
            }

            Console.WriteLine("\nWywołanie metody ParentMethod()\n");
            foreach (Parent item in list) {
                item.ParentMethod();
                Console.WriteLine();
            }

            Console.WriteLine("\nWywołanie metody ParentAbstractMethod()\n");
            foreach (Parent item in list) {
                item.ParentAbstractMethod();
                Console.WriteLine();
            }
        }
    }
}
