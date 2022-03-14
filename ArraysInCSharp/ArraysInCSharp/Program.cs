using System;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Einfacher Datentyp, der einen Wert gleichzeitig speichern kann. (auch Werttyp genannt)
            int a = 5;
            a = 6;

            // Ein Array zahlen mit Elemnten vom Typ int definiert, mit new Speicher angefordert
            // Der Datentyp Array ist ein Referenztyp, d. h, er speichert nur Adressen
            // 1. Variante
            int[] zahlen;
            zahlen = new int[5];

            zahlen[0] = 5;

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + " ");
            }
            Console.WriteLine(zahlen);

            Console.WriteLine();
            // 2. Weitere Art, Array zu definieren und zu initialisieren
            // Auf die Angabe der Arraygröße kann verzichtet werden
            int[] numbers = new int[] { 5, 19, 78, 33, 6, 8 }; // Array-Initialisierer

            for (int j  = 0; j < numbers.Length; j++)
            {
                Console.Write(numbers[j] + " ");
            }
            Console.WriteLine();

            zahlen = numbers;

            Console.WriteLine("Array zahlen");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + " ");
            }

            // Arrays sind typsicher
            //zahlen[2] = 3.5; // Fehler, da falscher Typ

            // Arrays sind nicht felxibel in der Länge

            // D. h.: Arrays sind typsicher, aber unflexibel in der Länge
            //zahlen[6] = 20;

            Console.WriteLine();
            // 3. Variante (Kurzform)

            string[] vornamen = { "Sabine", "Maik", "Heiko", "Dieter", "Sigi" };


            for (int i = 0; i < vornamen.Length; i++)
            {
                if (vornamen[i] == "Heiko")
                {
                    vornamen[i] = "Hans";
                }
                Console.Write(vornamen[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(vornamen);

            Console.WriteLine("Ausgabe mit foreach-Schleife");

            // Mit der foreach-Schleife kann nur lesend zugegriffen werden
            foreach (var item in vornamen)
            {
                //item*/ = "Heiner";
                Console.Write(item + " ");
            }


            // Übung: Definiert eine Array staedte mit Elemten vom Typ string
            // Initialisiert es mit 10 Elementen.
            // Gebt die Elemten mit einer aus.
            // Ersetzt die Elemente an der Stelle mit Index 5 u. 8 durch neue Angaben (Städte)
            // Gebt die Elemten mit einer aus.




        }
    }
}
