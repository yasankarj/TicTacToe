﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace TicTacToe
{
    class GamePlay
    {
        short[,] gameGrid = new short[3, 3];/*2d array to map the game
                                         * array elements will store 0 if no clicks yet
                                         * array elements will hold 1 if player 1 clicks
                                         * array elements will hold 2 f player 2 clicks
                                         */
        

        public short[,] GameGrid
        {
            get { return gameGrid; }
        }
        public int gameCounter = 0;     /*if game counter is divisible by 2, chance is to player1, else to player2. dominanat property for multi play game*/
        public Player player1;          /*Player object for player1*/
        public Player player2;          /*player object for player2*/
        public Stopwatch time = new Stopwatch();    /*stopwatch to to trace the time*/
        private bool terminateState = false;        /*this will be true if the game is over, win or tie or loose*/
        private int removableBtn = -1;              /*single player*/

        public int RemovableBtn
            /*Encapsulate, only the getter is set, it will be only change within the GamePlay*/
        {
            get { return removableBtn; }
        }

        public bool TerminateState
        {
            /*Encapsulate, only the getter is set, it will be only change within the GamePlay*/
            get { return terminateState; }
            
        }
        MusicPlay music = MusicPlay.getMusicPlayer();       //MusicPlayer to play sounds

        public GamePlay(String name1, String name2)
        {
            /*multiplayer game constructor*/
            player1 = new humanPlayer(name1,1);
            player2 = new humanPlayer(name2, -1);
        }

        public GamePlay(String name1)
        {
            /*single player game constructor*/
            player1 = new humanPlayer(name1, 1);
            player2 = new ComputerPlayer();
        }

        
        public void StartGame()
        {
            music.stopIntroSound();
            music.playGameSound();
            time.Start();
        }

        public void PlaySingle(int gridPosition)
        {
            int x = (gridPosition - 1) / 3;
            int y = gridPosition - (3 * x) - 1;
            short checker;
            if (gameCounter <= 9)
            {
                checker = player1.mark();
                gameGrid[x, y] = checker;
                checkGrid(checker);
                gameCounter++;

                gridPosition = player2.mark(gameGrid);
                x = (gridPosition - 1) / 3;
                y = gridPosition - (3 * x) - 1;
                checker = -1;
                gameGrid[x, y] = checker;
                checkGrid(checker);
                removableBtn = gridPosition;


                gameCounter++;
                Console.WriteLine("{[" + gameGrid[0, 0] + "][" + gameGrid[0, 1] + "][" + gameGrid[0, 2] + "}");
                Console.WriteLine("{[" + gameGrid[1, 0] + "][" + gameGrid[1, 1] + "][" + gameGrid[1, 2] + "}");
                Console.WriteLine("{[" + gameGrid[2, 0] + "][" + gameGrid[2, 1] + "][" + gameGrid[2, 2] + "}\n");
                checkGrid(checker);
            }
            
        }

        public void PlayMulti(int gridPosition)
        {
            int x = (gridPosition - 1) / 3;
            int y = gridPosition - (3 * x) - 1;
            short checker;

            if (gameCounter % 2 == 0)
            {
                checker = player1.mark();
                gameGrid[x, y] = checker;
            }
            else
            {
                checker = player2.mark();
                gameGrid[x, y] = checker;
            }
                


            gameCounter++;
            Console.WriteLine("{[" + gameGrid[0, 0] + "][" + gameGrid[0, 1] + "][" + gameGrid[0, 2] + "}");
            Console.WriteLine("{[" + gameGrid[1, 0] + "][" + gameGrid[1, 1] + "][" + gameGrid[1, 2] + "}");
            Console.WriteLine("{[" + gameGrid[2, 0] + "][" + gameGrid[2, 1] + "][" + gameGrid[2, 2] + "}\n");
            checkGrid(checker);
        }

      

        /*checkGrid method*/
        /*method to track the grid if a player completed the game*/
        public void checkGrid(short x)
        {
            short pattern_vert = 0;
            short pattern_horiz = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                { 
                    pattern_vert += gameGrid[i,j];
                    pattern_horiz += gameGrid[j,i];
                }

                if (pattern_vert == 3 * x || pattern_horiz == 3 * x)
                {
                    terminateState = true;
                    performWhenGrid(x);
                    break;
                }
                pattern_vert = 0;
                pattern_horiz = 0;
            }
            

                 /*check for first diagonal of the grid*/
                if (gameGrid[0, 0] == x && gameGrid[1, 1] == x && gameGrid[2, 2] == x)
                {
                    terminateState = true;
                    performWhenGrid(x);
                }

                 /*check for second diagonal of the grid*/
                else if (gameGrid[0, 2] == x && gameGrid[1, 1] == x && gameGrid[2, 0] == x)
                {
                    terminateState = true;
                    performWhenGrid(x);

                }

                else if (gameCounter == 9)
                {

                    //newMP.panelGrid.Enabled = false;
                    terminateState = true;
                    time.Stop();
                    Result newConForm = new Result();
                    newConForm.ShowDialog();

                }
                Console.WriteLine("#"+gameCounter+"#");
        }
        /*checkGrid method*/

        /*perform when grid is in a winning pattern*/
        public void performWhenGrid(int x)
        {
           //newMP.panelGrid.Enabled = false;
            music.stopGameSound();
            music.playConSound();
            time.Stop();
            long t = time.ElapsedMilliseconds;
            timeStamp timeC = new timeStamp(t / 1000);
            Result newConForm = new Result(x, player1.name, player2.name, timeC.show());

            newConForm.ShowDialog();
        }
        /* performWhenGrid finished*/
    }
}
