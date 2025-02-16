﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Board
    {
        private readonly Pieces[,] pieces = new Pieces[8, 8];

        public Pieces this[int row, int col]
        {
            get{ return pieces[row, col]; }
            set { pieces[row, col] = value; }
        }

        public Pieces this[Position pos]
        {
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value; }
        }
        public static Board Initial()
        {
            Board board = new Board();
            board.AddStartPieces();
            return board;
        }

        private void AddStartPieces()
        {

        }
    }
}
