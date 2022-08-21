// See https://aka.ms/new-console-template for more information

namespace TicTacToe
{
    class Program
    {
        //the playfield
        static char[,] playfield =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };


        static int turns = 0;
        public static void Main(string[] args)
        {
            int player = 2; //player 1 starts
            int input = 0;
            bool inputCorrect = true;

            //Run code as long as the program runs
            do
            {
                if (player == 2) //player 1's turn
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if(player == 1)//player 2's turn
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                setField();

                #region
                //Check winning condition
                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if ((playfield[0,0] == playerChar) && (playfield[0,1] == playerChar) && (playfield[0,2] == playerChar)
                        || (playfield[1, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[1, 2] == playerChar)
                        || (playfield[2, 0] == playerChar) && (playfield[2, 1] == playerChar) && (playfield[2, 2] == playerChar)
                        || (playfield[0, 0] == playerChar) && (playfield[1, 0] == playerChar) && (playfield[2, 0] == playerChar)
                        || (playfield[0, 1] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 1] == playerChar)
                        || (playfield[0, 2] == playerChar) && (playfield[1, 2] == playerChar) && (playfield[2, 2] == playerChar)
                        || (playfield[0, 0] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 2] == playerChar)
                        || (playfield[0, 2] == playerChar) && (playfield[1, 1] == playerChar) && (playfield[2, 0] == playerChar))
                    {
                        if(playerChar == 'X')
                            Console.WriteLine("\nPlayer 2 has won!");
                        else
                            Console.WriteLine("\nPlayer 1 has won!");

                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();

                        resetField();


                        break;

                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDRAW!");
                        Console.WriteLine("Please press any key to reset the game!");
                        Console.ReadKey();
                        resetField();
                        break;
                    }
                }



                #endregion

                #region
                //Test if field is already taken
                do
                {
                    Console.WriteLine("\nplayer {0}: Choose your field! ", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a number!");
                    }

                    if ((input == 1) && (playfield[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playfield[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playfield[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playfield[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playfield[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playfield[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playfield[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playfield[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playfield[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Incorrect input! Please use another field");
                        inputCorrect = false;
                    }
                    #endregion

                } while (!inputCorrect);
            } while (true);
        }

        public static void setField()
        {
            Console.Clear();
            Console.WriteLine("       |       |       ");
            //TODO replace numbers wirh variables
            Console.WriteLine("   {0}   |   {1}   |   {2}", playfield[0,0], playfield[0, 1], playfield[0, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}", playfield[1, 0], playfield[1, 1], playfield[1, 2]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}", playfield[2, 0], playfield[2, 1], playfield[2, 2]);
            Console.WriteLine("       |       |       ");
            turns++;
        }

        public static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';
            switch (input)
            {
                case 1: playfield[0, 0] = playerSign; break;
                case 2: playfield[0, 1] = playerSign; break;
                case 3: playfield[0, 2] = playerSign; break;
                case 4: playfield[1, 0] = playerSign; break;
                case 5: playfield[1, 1] = playerSign; break;
                case 6: playfield[1, 2] = playerSign; break;
                case 7: playfield[2, 0] = playerSign; break;
                case 8: playfield[2, 1] = playerSign; break;
                case 9: playfield[2, 2] = playerSign; break;
            }
        }

        public static void resetField()
        {
           char[,] playfieldInitial =
            {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
            };
            playfield = playfieldInitial;
            setField();
            turns = 0;
        }

     
    }
}
