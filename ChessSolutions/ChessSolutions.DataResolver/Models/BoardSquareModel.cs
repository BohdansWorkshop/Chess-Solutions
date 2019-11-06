using System;
using System.Collections.Generic;
using System.Text;

namespace ChessSolutions.DataResolver.Models
{
    public class BoardSquareModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public SquareColor Color { get; set; } = SquareColor.Unset;
    }

    public enum SquareColor
    {
        Unset,
        Black,
        White
    }
}
