using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace punyreferences
{
    public class ReferenceParser
    {
        private List<string> _references;

        public ReferenceParser()
        {
            if (_references != null)
                _references.Clear();
        }


        public void ParseReferences(string filePath)
        {
            XNamespace msbuild = "http://schemas.microsoft.com/developer/msbuild/2003";
            XDocument projDefinition = XDocument.Load(filePath);
            IEnumerable<string> references = projDefinition
                .Element(msbuild + "Project")
                .Elements(msbuild + "ItemGroup")
                .Elements(msbuild + "Reference")
                .Elements(msbuild + "HintPath")
                //.Attributes("Include")     
                .Select(refElem => refElem.Value);
                _references.AddRange(references);

            foreach (var value in _references)
            {
                Console.WriteLine(value);
            }
        }


        public List<string> ReferenceList => _references;
    }
}