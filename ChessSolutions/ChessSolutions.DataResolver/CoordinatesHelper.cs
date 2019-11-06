using ChessSolutions.DataResolver.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessSolutions.DataResolver
{
    public static class CoordinatesHelper
    {
        const int maxOX = 8;
        const int minOX = 1;
        const int maxOY = 8;
        const int minOY = 1;
        private static readonly Dictionary<string, int> LettersCoordinates;

        static CoordinatesHelper()
        {
            var deskLetters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
            LettersCoordinates = new Dictionary<string, int>();
            for (int i = 0; i < deskLetters.Length; i++)
            {
                LettersCoordinates.Add(deskLetters[i], i + 1);
            };
        }

        public static bool IsValidCoordinates(int x, int y)
        {
            if (x <= maxOX && x >= minOX && y <= maxOY && y >= minOY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static BoardSquareModel ChessToNumericalCoordinates(string input)
        {
            input = input.Replace(" ", "").ToLower();
            var color = (SquareColor)int.Parse(input[0].ToString());

            var firstPointValue = input[1].ToString();
            var secondNumber = int.Parse(input[2].ToString());
            return new BoardSquareModel() { X = LettersCoordinates[firstPointValue], Y = secondNumber, Color = color };
        }


        public static string NumericalToChessCoordinates(int x, int y)
        {
            var chars = (char)(x - 1 + 'A');
            return $"{chars.ToString()}{y}";
        }
    }
}
