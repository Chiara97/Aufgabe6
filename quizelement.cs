using System;

namespace Aufgabe6
{
    public class Quizelement
    {
        public string question;
        public string[] answers; 
        public string correct;

        public void IsAnswerCorrect(string choice, int i, int score)
        {
            if (i == 0 && choice == "Konrad Adenauer")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
           
            }
            
            if (i == 1 && choice == "Orange")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
                              
            }

            if (i == 2 && choice == "Kolibri")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
                             
            }

            if (i == 3 && choice == "1000")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
                             
            }
            if (i == 4 && choice == "Willie")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
                             
            }
            if (i == 5 && choice == "Bermudas")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
                             
            }
            if (i == 6 && choice == "8 Minuten")
            {
                score++;
                Console.WriteLine("Richtige Antwort. Deine Punkte: " + score);
            }
            
            i++;
            AbfrageWasErMachenWill(i, score);
                                    
        }
       
        public static void AbfrageWasErMachenWill(int i, int score)
        {
            Console.WriteLine ("Tippe 1: Noch eine weitere Frage erstellen");
            Console.WriteLine ("Tippe 2: Quiz beantworten");
            Console.WriteLine ("Tippe 3: Quiz beenden");

            int eingabe = int.Parse(Console.ReadLine());

            if (eingabe == 1)
            {
                erstellen.FragenErstellen(i, score);
            }
            if (eingabe == 2)
            {
                Program p = new Program();
                p.FragenAusgabe(i, score);     
            }
            if (eingabe == 3)
            {
                Console.WriteLine("Auf Wiedersehen.");
            }
        }
    }
}