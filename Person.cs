using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace SOAP_asmx
{
    [XmlInclude(typeof(Employ))]
    [XmlInclude(typeof(Manager))]
    public class Person
    {
        public string Fam;
        public string Im;
        public string Ot;
    }
}