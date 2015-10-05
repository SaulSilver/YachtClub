using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace YachtClub
{
    public class FileInteraction
    {

        XmlTextReader reader;
        String path = "Storage.xml";
        private Guid guid;

        public Guid myGuid { get { return guid; } set { guid = value; } }

        public Object get()
        {
          XElement root = XElement.Load("Storage.xml");
          IEnumerable<XElement>  =
                from el in root.Elements("Members")
                where (string)el.Attribute("guid") == "guid"
                select el;
           
        }

        public List<Object> getAll()
        {
            throw new System.NotImplementedException();
        }

        public virtual void add(){}

        public void update()
        {
            throw new System.NotImplementedException();
        }

        public void delete()
        {
            throw new System.NotImplementedException();
        }

        public void clear()
        {
            throw new System.NotImplementedException();
        }
    }
}