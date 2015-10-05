using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YachtClub
{
    public class Boat
    {
        private double length;
        private string type;

        public enum Difficulty { Easy, Normal, Hard };

        private Difficulty _Difficulty;

        public void SetDifficulty(Difficulty difficulty)
        {
            _Difficulty = difficulty;
        }

        public Difficulty GetDifficulty()
        {
            return _Difficulty;
        }
    }
}