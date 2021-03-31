using System;

namespace TicTacToeKonsole
{
    class Program
    {
        static void ResetBoard(String[,] liste)
        {
            for(int i = 0; i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    liste[i, j] = "-";
                }
            }
                        
                         
        }

        static void ausgabe(String[,] liste)
        { 
            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<3;j++)
                {
                    Console.Write(liste[i,j]);
                }
                Console.Write("\n");
            }
        }

        static void tableSet( String[,] liste, String O, int eingabeSet)
        {
            
                Console.WriteLine("Where u wanna place?: ");
                eingabeSet = Convert.ToInt32(Console.ReadLine());
                switch(eingabeSet)
                {
                    case 1:
                        liste[0, 0] = O;
                        break;
                    case 2:
                        liste[0, 1] = O;
                        break;
                    case 3:
                        liste[0, 2] = O;
                        break;
                    case 4:
                        liste[1, 0] = O;
                        break;
                    case 5:
                        liste[1, 1] = O;
                        break;
                    case 6:
                        liste[1, 2] = O;
                        break;
                    case 7:
                        liste[2,0] = O;
                        break;
                    case 8:
                        liste[2, 1] = O;
                        break;
                    case 9:
                        liste[2, 2] = O;
                        break;
                }

            

            
        }

        static void Main(string[] args)
        {
            String[,] board = new string[3, 3];

            bool turnMeter;
            
            String X = "x";
            String O = "o";
            int eingabeSet = 0;

            ResetBoard(board);
            ausgabe(board);


            Console.WriteLine("WHOS SHOULD START? X OR O \n Answer with X OR O\n"); 
            String xoro = Console.ReadLine();
            xoro = xoro.ToLower();
            if(xoro == "o")
            {
                turnMeter = true;
            }                                                                                       //WHO SHOULD START MY N-?!?!?!
            else
            {
                turnMeter = false;
            }

            //------------------------
            for (int i = 0; i < 9; i++)
            {
                if (turnMeter == true)
                {
                    tableSet(board, O, eingabeSet);
                    turnMeter = !turnMeter;
                }
                else
                {
                    tableSet(board, X, eingabeSet);
                    turnMeter = !turnMeter;
                }
                ausgabe(board);
            }




        }
    }
}
