using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace YachtClub
{
    public class Member : FileInteraction
    {
        private string last_Name;
        private string first_Name;
        private int personal_Number;
        private List<Boat> boats;

       
        /// <summary>
        /// Adds a new member and all his boats to the xml file (like a saving process)
        /// </summary>
        public override void add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlElement id = doc.CreateElement(myGuid.ToString());
            id.SetAttribute(last_Name, first_Name, personal_Number.ToString());

            XmlElement xBoats = doc.CreateElement("boats");
            id.AppendChild(xBoats);

            foreach(Boat b in boats){
                Boat newBoat = new Boat();
                XmlElement xNewBoat = doc.CreateElement(newBoat.myGuid.ToString());
                xNewBoat.SetAttribute(newBoat.Type, newBoat.Length.ToString());
                xBoats.AppendChild(xNewBoat);
            }

            doc.AppendChild(id);


        }
    }

}