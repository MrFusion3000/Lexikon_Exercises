using System;

namespace Lexikon_Exercises
{
    class Program
    {
        static void Main()
        {
            Program Exercises = new Program();

            Exercises.Menu();
            
        }

        public void Menu()
        { // *** Start Main() *** 
          //Huvudmenyn listar alla grundalternativ för programmet
            Console.SetWindowSize(100, 40);             // Sätt fönsterstorleken till 100 b, 40 h

            int antalMenyval = 9;                       // initiera antal menyval på huvudmenyn
            int menyVal;                                // initiera heltalsvariabel menyVal för användarinput

            // *** Switch och case med do-while-loop så länge menyVal är annat än 0
            do
            {
                Console.Clear();                        // Rensa skärmen
                Console.WriteLine("* ** *** H U V U D M E N Y *** ** *\n");
                Console.WriteLine("Välj ett alternativ (och tryck Enter):\n");
                Console.WriteLine("1. Uppg  1 - ");
                Console.WriteLine("2. Uppg  2 - ");
                Console.WriteLine("3. Uppg  3 - ");
                Console.WriteLine("4. Uppg  4 - ");
                Console.WriteLine("5. Uppg  5 - ");
                Console.WriteLine("6. Uppg  6 - ");
                Console.WriteLine("7. Uppg  7 - ");
                Console.WriteLine("8. Uppg  8 - n");
                Console.WriteLine("99. Fler Övningar  \n\n");
                Console.WriteLine("0. Avsluta \n");

                menyVal = Check_Valid(antalMenyval);   // Kontroll av godkända tecken och blockering av annat än siffror

                switch (menyVal)
                {
                    case 1:
                        Exercise1();
                        break;
                    //case 2:
                    //    Uppg2();
                    //    break;
                    //case 3:
                    //    Uppg3();
                    //    break;
                    //case 4:
                    //    Uppg4();
                    //    break;
                    //case 5:
                    //    Uppg5();
                    //    break;
                    //case 6:
                    //    Uppg6();
                    //    break;
                    //case 7:
                    //    Uppg7();
                    //    break;
                    //case 8:
                    //    Uppg8();
                    //    break;
                    //case 99:
                    //    Menu2();
                    //    break;
                    case 0:                             // Val 0, ger meddelande till användaren och avslutar programmet.
                        Console.WriteLine("Du har avslutat programmet.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Felaktigt val. Endast menyval mellan 0 - " + (antalMenyval--) + " är giltiga.");
                        break;
                }

            } while (menyVal != 0);
        } // **** End Main() ****

        public int Check_Valid(int _antalMenyval)
        { // *** Start CheckValid *** 
          // Kontroll av menyval
            int antalMenyval = _antalMenyval;
            int _menyVal;
            while (!int.TryParse(Console.ReadLine(), out _menyVal))
            {
                Console.WriteLine("Endast något av menyvalen 0 - " + (antalMenyval--) + " är giltiga.");

            }
            return _menyVal;        // Metoden returnerar ett korrekt valalternativ

        }   // **** End Check_Valid() ****

        public void SplashScreen()
        {
            Console.WriteLine(");
        }

        public void Exercise1()
        {

        }
    }
}
