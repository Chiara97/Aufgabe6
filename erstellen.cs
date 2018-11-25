using System;

namespace Aufgabe6
{
    public class erstellen
    {
        public static string FragenErstellen(int i, int score)
        {
            Console.WriteLine("Tippe deine Frage ein:");
            string FragenEingabe = Console.ReadLine();
            AnzahlAntwortmöglichkeiten(i, score);
            return FragenEingabe;
        }

        public static void AnzahlAntwortmöglichkeiten(int i, int score)
        {
            Console.WriteLine("Wie viele Antwortmöglichkeiten soll deine Frage haben? (Zwischen 2-6)");
            int anzahl = int.Parse(Console.ReadLine());
            Antworterstellen(anzahl, i, score);          
        }

        public static void Antworterstellen(int anzahl, int i, int score)
        {
            int r = 0;
            while (r < anzahl)
            {
                Console.WriteLine("Tippe deine Antwortmöglichkeit/en ein:");
                string AntwortEingabe = Console.ReadLine();
                r++;
            }
            Quizelement.AbfrageWasErMachenWill(i, score);
        }

        
    }
}