using System;
using System.Dynamic;

namespace Lexikon_Exercises
{
    class Program
    {
        static void Main()
        {
            Program Exercises = new Program();

            Exercises.SplashScreen();
            Exercises.Menu();
            
        }

        public void Menu()
        { // *** Start Main() *** 
          //Huvudmenyn listar alla grundalternativ för programmet
            Console.SetWindowSize(100, 40);             // Sätt fönsterstorleken till 100 tecken bredd, 40 tecken höjd

            int antalMenyval = 9;                       // initiera antal menyval på huvudmenyn
            int menyVal;                                // initiera heltalsvariabel menyVal för användarinput

            // *** Switch och case med do-while-loop så länge menyVal är annat än 0
            do
            {
                Console.Clear();                        // Rensa skärmen
                Console.WriteLine("\n\n\n\t\t\t* ** *** H U V U D M E N Y *** ** *\n");
                //Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "* ** *** H U V U D M E N Y *** ** *\n"));
                Console.WriteLine("\t\t\tVälj ett alternativ (och tryck Enter):\n");
                Console.WriteLine("\t\t\t1. Uppg  1 - Print welcome message  ");
                Console.WriteLine("\t\t\t2. Uppg  2 - DateTime");
                Console.WriteLine("\t\t\t3. Uppg  3 - ");
                Console.WriteLine("\t\t\t4. Uppg  4 - ");
                Console.WriteLine("\t\t\t5. Uppg  5 - ");
                Console.WriteLine("\t\t\t6. Uppg  6 - ");
                Console.WriteLine("\t\t\t7. Uppg  7 - ");
                Console.WriteLine("\t\t\t8. Uppg  8 - n");
                Console.WriteLine("\t\t\t99. Fler Övningar  \n\n");
                Console.WriteLine("\t\t\t0. Avsluta \n");

                menyVal = Check_Valid(antalMenyval);   // Kontroll av godkända tecken och blockering av annat än siffror

                switch (menyVal)
                {
                    case 1:
                        Exercise1();
                        break;
                    case 2:
                        Exercise2();
                        break;
                    //case 3:
                    //Exercise1();
                    //    break;
                    //case 4:
                    //Exercise1();
                    //    break;
                    //case 5:
                    //Exercise1();
                    //    break;
                    //case 6:
                    //Exercise1();
                    //    break;
                    //case 7:
                    //Exercise1();
                    //    break;
                    //case 8:
                    //Exercise1();
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
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("\t\t\tW e l c o m e  t o  t h e");
            Console.WriteLine("\t\t\tD O S  i n s p i r e d  U n i v e r s e");
            Console.WriteLine("\t\t\to f");
            Console.WriteLine("\t\t\tT e s t  E x c e r s i s e s !");
            Console.WriteLine("\n\n\t\t\tP r e s s  a n y  k e y  t o  c o n t i n u e !");
            Console.ReadKey();
        }

        public void Exercise1()
        {
            string firstName = "Nicolas";
            string lastName = "Lewentorp";

            Console.Clear();                        // Rensa skärmen

            Console.WriteLine("Hello {0} {1}! \nI'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);

            Console.ReadKey();
        }

        public void Exercise2()
        {

        }

        public void Exercise3()
        {

        }
    }
}
