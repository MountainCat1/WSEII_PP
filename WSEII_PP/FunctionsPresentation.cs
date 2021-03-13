using System;
using System.Collections.Generic;
using System.Text;

namespace WSEII_PP
{
    // 2. funkcje, w szczególności przesyłanie parametrów przez wartość i przez referencję
    static class FunctionsPresentation
    {
        public class TestClass
        {
            public int variableA;
            public string variableB;
        }

        public static void Present() {
            int a = 5;

            Console.WriteLine($"Początkowa wartość a = {a}");
            Add(a, 5);
            Console.WriteLine($"Zmienna a po użyciu funkcji z parametrem jako wartością: {a}"); // aby a się zmieniło trzeba uzyć "a = Add(a, b);"
            Add(ref a, 5);
            Console.WriteLine($"Zmienna a po użyciu funkcji z parametrem jako referencją: {a}"); // a zmienia się ze względ iż jest referencją

            Console.WriteLine();

            TestClass testObject = new TestClass() { variableA = 6, variableB = "Lorem Ipsum"};
            Console.WriteLine("Początkowa wartość testObject = ({0}, {1})", testObject.variableA, testObject.variableB);

            SetVaraiblesToNew(testObject);
            Console.WriteLine("Wartość po użyciu fukcji parametrem jako wartością: = ({0}, {1})",
                testObject.variableA, testObject.variableB);
            // Pomimo, że nie została użyta referencja testObject nadal uległ zmianie, dzieje sie tak w przypadku obiektów klas


            testObject = new TestClass() { variableA = 6, variableB = "Lorem Ipsum" }; // ustawianie wartości do domyślnych
            Console.WriteLine("\nUstawianie wartości na domyslne... testObject = ({0}, {1})", testObject.variableA, testObject.variableB);

            SetVaraiblesToNewCreatingNewObject(testObject);
            Console.WriteLine("Wartość po użyciu fukcji, nadpisującej obiekt, z parametrem jako wartością: = ({0}, {1})",
                testObject.variableA, testObject.variableB);
            // Jeżeli jednak fukcja nadpisuje object jako nowy wartości się nie zmienią

            SetVaraiblesToNewCreatingNewObject(ref testObject);
            Console.WriteLine("Wartość po użyciu fukcji, nadpisującej obiekt, z parametrem jako referencją: = ({0}, {1})",
                testObject.variableA, testObject.variableB);
            // Użycie referencji spowoduje, że nawet nadpisanie obiektu pozwoli go nadal edytować
        }

        public static int Add(int a, int b) // parametr jako wartość
            => a + b;
        public static void Add(ref int a, int b) { // parametr jako referencja
            a += b;
        }
        public static void SetVaraiblesToNew(TestClass testObject) {
            testObject.variableA = 21;
            testObject.variableB = "New Value";
        }
        public static void SetVaraiblesToNew(ref TestClass testObject) {
            testObject.variableA = 21;
            testObject.variableB = "New Value";
        }
        public static void SetVaraiblesToNewCreatingNewObject(TestClass testObject) {
            testObject = new TestClass();
            testObject.variableA = 21;
            testObject.variableB = "New Value";
        }
        public static void SetVaraiblesToNewCreatingNewObject(ref TestClass testObject) {
            testObject = new TestClass();
            testObject.variableA = 21;
            testObject.variableB = "New Value";
        }
    }
}
