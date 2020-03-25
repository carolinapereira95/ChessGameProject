﻿using System;
using System.Collections.Generic;
using System.Text;
using ChessGameProject.board.Enum;
using ChessGameProject.board;

namespace ChessGameProject.board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int MoveCount { get; protected set; }
        public Board Board { get; protected set; }

        public Piece ()
        {
        }

        public Piece( Board board, Color color)
        {
            Position = null;
            Board = board;
            Color = color;
            MoveCount = 0;
        }

        //Increase quantity the movements
        public void IncreaseQuantityMovements ()
        {
            MoveCount++;
        }
    }
}
