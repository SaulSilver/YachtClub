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

        public virtual Object get(){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");

            XmlElement xmlElement = doc.GetElementById(guid.ToString());
            return xmlElement;
        }

        public List<Object> getAll(){
            throw new System.NotImplementedException();
        }

        public virtual void add(){}

        public virtual void add(Guid memberID) { }
        
        public void delete(){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlElement xmlElement = doc.GetElementById(guid.ToString());            
        }

        public void clear(){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");
            XmlNode rootNode = doc.FirstChild;
            rootNode.RemoveAll();
        }

        public Boolean lookup(){
            XmlDocument doc = new XmlDocument();
            doc.Load("Storage.xml");

            if(doc.GetElementById(guid.ToString()) == null){
                return false;
            }
            else{
                return true;
            }
        }
    }
}