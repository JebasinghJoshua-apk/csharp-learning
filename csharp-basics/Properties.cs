using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace csharp_basics
{
    public class Company
    {
        private string _companyName = "Apple";
        public string CompanyName   // property
        {
            get { return _companyName; }   // get method
            set { _companyName = value; }  // set method
        }
    }
}
