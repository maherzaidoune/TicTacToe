using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class gamePlay
    {
        public int x { get; set; }
        public int y { get; set; }
        int[,] table = new int[3,3];
        public gamePlay()
        {
            

        }

        public int addToBoard(int x,int y,player p)
        {
            
            table[x, y] = p.id;
            Console.WriteLine(p.name + "   " + table[x, y]);
            if (checkWin(p))
                return 1;
            return 0;
        }

        private Boolean checkWin(player p)
        {
            //return checkDiagonal(p)|| checkRow(p) || checkComumn(p);
            return ((table[0, 0] == p.id) && (table[1, 0] == p.id) && (table[2, 0] == p.id)) ||
                ((table[0, 1] == p.id) && (table[1, 1] == p.id) && (table[2, 1] == p.id)) ||
                ((table[0, 2] == p.id) && (table[1, 2] == p.id) && (table[2, 2] == p.id)) ||
                ((table[0, 0] == p.id) && (table[0, 1] == p.id) && (table[0, 2] == p.id)) ||
                ((table[1, 0] == p.id) && (table[1, 1] == p.id) && (table[1, 2] == p.id)) ||
                ((table[2, 0] == p.id) && (table[2, 1] == p.id) && (table[2, 2] == p.id)) ||
                ((table[0, 0] == p.id) && (table[1, 1] == p.id) && (table[2, 2] == p.id)) ||
                ((table[2, 0] == p.id) && (table[1, 1] == p.id) && (table[0, 2] == p.id)
                );

        }

        public void gameOver()
        {
            for(int i = 0;i <3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    table[i, j] = 0;
                }
            }
        }

        //private Boolean checkComumn(player p)
        //{
        //    if (
        //        ((table[0, 0] == p.id) && (table[1, 0] == p.id) && (table[2, 0] == p.id)) ||
        //        ((table[0, 1] == p.id) && (table[1, 1] == p.id) && (table[2, 1] == p.id)) ||
        //        ((table[0, 2] == p.id) && (table[1, 2] == p.id) && (table[2, 2] == p.id))
        //        )
        //        return true;
        //    return false;
        //}

        //private Boolean checkRow(player p)
        //{
        //    if (
        //        ((table[0, 0] == p.id) && (table[0, 1] == p.id) && (table[0, 2] == p.id)) ||
        //        ((table[1, 0] == p.id) && (table[1, 1] == p.id) && (table[1, 2] == p.id)) ||
        //        ((table[2, 0] == p.id) && (table[2, 1] == p.id) && (table[2, 2] == p.id))
        //        )
        //        return true;
        //    return false;
        //}

        //private Boolean checkDiagonal(player p)
        //{
        //    if (
        //        ((table[0, 0] == p.id) && (table[1, 1] == p.id) && (table[2, 2] == p.id)) ||
        //        ((table[2, 0] == p.id) && (table[1, 1] == p.id) && (table[0, 2] == p.id)) 
        //        )
        //        return true;
        //    return false;
        //}
    }
}
