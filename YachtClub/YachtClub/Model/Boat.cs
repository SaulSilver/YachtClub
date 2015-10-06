using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace YachtClub
{
    public class Boat : FileInteraction
    {
        private double length;   
        public double Length { get { return length; }  set { length = value;}}
        public enum boat_Type { sailboat, motorsailer, kayak, other };
        private boat_Type type;

        public void SetType(boat_Type boatType){type = boatType;}
        public boat_Type GetType(){return type;}

        public override void add(Guid memberID){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");

            XmlNode xmlElement =  doc.GetElementById(memberID.ToString());
            XmlNode x = xmlElement.FirstChild;

            XmlElement newBoat = doc.CreateElement(myGuid.ToString());
            newBoat.SetAttribute(length.ToString(), type.ToString());

            x.AppendChild(newBoat);            
        }
    }
}