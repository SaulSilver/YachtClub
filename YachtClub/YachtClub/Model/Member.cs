using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace YachtClub
{
    public class Member : FileInteraction
    {        
        private string last_Name;
        private string first_Name;
        private int personal_Number;
        private int member_Id;
        private List<Boat> boats_List;

        public string last_name { get { return last_Name; } set { value = last_Name; } }
        public string first_name { get { return first_Name; } set { value = first_Name; } }
        public int personal_number { get { return personal_Number; } set { value = personal_Number; } }
        public int member_id { get {return member_Id; } set{ value = member_Id;}}
        public List<Boat> boats { get { return boats; } set { value = boats; } }

        /// <summary>
        /// Adds a new member and all his boats to the xml file (like a saving process)
        /// </summary>
        public override void add(){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlElement id = doc.CreateElement(myGuid.ToString());
            id.SetAttribute(last_Name, first_Name, personal_Number.ToString());

            XmlElement xBoats = doc.CreateElement("boats");
            id.AppendChild(xBoats);

            foreach (Boat b in boats){
                Boat newBoat = new Boat();
                XmlElement xNewBoat = doc.CreateElement(newBoat.myGuid.ToString());
                xNewBoat.SetAttribute(newBoat.GetType().ToString(), newBoat.Length.ToString());
                xBoats.AppendChild(xNewBoat);
            }
            doc.AppendChild(id);
        }      
        
    }

   
}

