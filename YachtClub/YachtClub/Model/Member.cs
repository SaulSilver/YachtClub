using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YachtClub
{
    public class Member : FileInteraction
    {
        
        private string last_Name;
        private string first_Name;
        private int personal_Number;
        private List<Boat> boats;

        public string last_name { get { return last_Name; } set { value = last_Name; } }
        public string first_name { get { return first_Name; } set { value = first_Name; } }
        public int personal_number { get { return personal_Number; } set { value = personal_Number; } }
        public List<Boat> boaths { get; set; }
    }
}