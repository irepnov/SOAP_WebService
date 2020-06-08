using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace SOAP_asmx
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://goga.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        //принимает
        public Person[] GetPerson(Person[] pers)
        {
            return pers;
        }
        /*
         <?xml version="1.0" encoding="utf-8"?>
<soap12:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap12="http://www.w3.org/2003/05/soap-envelope">
  <soap12:Body>
    <GetPerson xmlns="http://goga.org/">
      <pers>
        <Person xsi:type="Employ">
          <Fam>dsf</Fam>
          <Im>string</Im>
          <Ot>string</Ot>
          <Dept>sdfsdf</Dept>
        </Person>
        <Person>
          <Fam>string</Fam>
          <Im>string</Im>
          <Ot>string</Ot>
        </Person>
        <Person xsi:type="Manager">
          <Fam>string</Fam>
          <Im>string</Im>
          <Ot>string</Ot>
          <Sales>222</Sales>
        </Person>
      </pers>
    </GetPerson>
  </soap12:Body>
</soap12:Envelope>


<soap:Envelope xmlns:soap="http://www.w3.org/2003/05/soap-envelope" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
   <soap:Body>
      <GetPersonResponse xmlns="http://goga.org/">
         <GetPersonResult>
            <Person xsi:type="Employ">
               <Fam>dsf</Fam>
               <Im>string</Im>
               <Ot>string</Ot>
               <Dept>sdfsdf</Dept>
            </Person>
            <Person>
               <Fam>string</Fam>
               <Im>string</Im>
               <Ot>string</Ot>
            </Person>
            <Person xsi:type="Manager">
               <Fam>string</Fam>
               <Im>string</Im>
               <Ot>string</Ot>
               <Sales>222</Sales>
            </Person>
         </GetPersonResult>
      </GetPersonResponse>
   </soap:Body>
</soap:Envelope>         
         */
    }
}
