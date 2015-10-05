using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YachtClub
{
    public class Boat : FileInteraction
    {


     


        private double length;
        

        public double Length { get { return length; }  set { length = value;  }  }


        public enum boat_Type { sailboat, motorsailer, kayak, other };

        private boat_Type _Difficulty;

    public void SetType(boat_Type difficulty)
    {
    _Difficulty = difficulty;
    }

    public boat_Type GetType()
    {
    return _Difficulty;
    }   

    }
}