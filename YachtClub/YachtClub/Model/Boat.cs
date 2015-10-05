﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace YachtClub
{
    public class Boat : FileInteraction
    {
        private double length;
        private string type;

        public double Length { get { return length; } set { length = value; } }
        public string Type { get { return type; } set { type = value; } }

        public override void add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlElement id = doc.CreateElement(myGuid.ToString());
            id.SetAttribute(length.ToString(), type);
        }
    }
}