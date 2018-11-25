using System;


namespace Aufgabe6
{
    class Program
    { 
        public int score = 0;

        public static void Main(string[] args)
        {
            Console.WriteLine("Tippe 1 für: Quizfragen erstellen.");
            Console.WriteLine("Tippe 2 für: Quizfragen beantworten");
            int eingabe = int.Parse(Console.ReadLine());

            int i = 0;
            if (eingabe == 1)
            {
                Program p = new Program();
                erstellen.FragenErstellen(i, p.score);
            }
            if (eingabe == 2)
            {
                Program p = new Program();
                p.FragenAusgabe(i, p.score);
            }
            
                    
        }
        public void FragenAusgabe(int i, int score)
        {
            Console.WriteLine("Deine beantworteten Fragen: " + i);
            Console.WriteLine("Deine Punktzahl: " + score);


            Quizelement quiz1 = new Quizelement();
            quiz1.question = "Wer war der erste Bundeskanzler der BDR?";

            Quizelement quiz2 = new Quizelement();
            quiz2.question = "Welche Farbe entsteht, wenn man Rot und Gelb mischt?";

            Quizelement quiz3 = new Quizelement();
            quiz3.question = "Wie heißt der kleinste Vogel?";

            Quizelement quiz4 = new Quizelement();
            quiz4.question = "Wieviel Millimeter hat ein Meter?";

            Quizelement quiz5 = new Quizelement();
            quiz5.question = "Wie heißt der Freund von Biene Maja? ";

            Quizelement quiz6 = new Quizelement();
            quiz6.question = "Wie heißen halblange Hose?";

            Quizelement quiz7 = new Quizelement();
            quiz7.question = "Wie lange braucht das Licht in etwa von der Sonne zur Erde?";            

            string[] question = new string[7];
            question[0] = quiz1.question;
            question[1] = quiz2.question;
            question[2] = quiz3.question;
            question[3] = quiz4.question;
            question[4] = quiz5.question;
            question[5] = quiz6.question;
            question[6] = quiz7.question;

            
            
            if (i < question.Length)
            {
                Console.WriteLine(question[i]);
                Answers a = new Answers();
                a.AntwortenAusgabe(i, score);
            }    

            if (i == 7)
            {
                Console.WriteLine("Ende des Programms");
            }    
        }      
    }
}
