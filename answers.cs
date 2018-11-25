using System;
using System.Collections.Generic;

namespace Aufgabe6
{
    public class Answers
    {
        public string question;
        public string correct;
        public string choice;


        public void AntwortenAusgabe(int i, int score)
        {
            Quizelement quiz1 = new Quizelement(); 
            quiz1.answers = new string[4] {"Barak Obama ", "Helmut Kohl ", "Konrad Adenauer ", "Angela Merkel "};            
            
            Quizelement quiz2 = new Quizelement();
            quiz2.answers = new string[2] {"Orange ", "Gelb "};

            Quizelement quiz3 = new Quizelement();
            quiz3.answers = new string[5] {"Bachstelze ", "Amsel ", "Kolibri ", "Grünfink ", "Kleiber "};

            Quizelement quiz4 = new Quizelement();
            quiz4.answers = new string[4] {"100", "1000", "10.000", "10"};

            Quizelement quiz5 = new Quizelement();
            quiz5.answers = new string[6] {"Puck", "Flip", "Willie", "Turka", "Thekla", "Fridolin"};

            Quizelement quiz6 = new Quizelement();
            quiz6.answers = new string[2] {"Bahamas", "Bermudas"};

            Quizelement quiz7 = new Quizelement();
            quiz7.answers = new string[6] {"es ist sofort da", "8 Jahre", "8 Minuten", "8 Tage", "8 Sekunden", "8 Millisekunden"};

            if (i == 0)
            {
                foreach (string z in quiz1.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }
        
            if (i == 1)
            {
                foreach (string z in quiz2.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }
            
            if (i == 2)
            {
                foreach (string z in quiz3.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }            

            if (i == 3)
            {
                foreach (string z in quiz4.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }            

            if (i == 4)
            {
                foreach (string z in quiz5.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }
            
            if (i == 5)
            {
                foreach (string z in quiz6.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }

            if (i == 6)
            {
                foreach (string z in quiz7.answers)
                {
                    System.Console.Write("{0} ", z);
                }
            }
            if (i == 7)
            {
                Quizelement.AbfrageWasErMachenWill(i, score);
            } 
            
            Console.WriteLine("Schreibe die richtige Antwort:");
            string eingabe = Console.ReadLine(); 
            Quizelement q = new Quizelement();
            q.IsAnswerCorrect(eingabe, i, score);
        
        }    
    }
}