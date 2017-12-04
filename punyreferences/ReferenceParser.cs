using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace punyreferences
{
    public class ReferenceParser
    {
        private List<string> _references = new List<string>();
        private List<string> _beautifiedReferences = new List<string>();

        public void ParseReferences(string filePath)
        {
            XNamespace msbuild = "http://schemas.microsoft.com/developer/msbuild/2003";
            XDocument projDefinition = XDocument.Load(filePath);
            IEnumerable<string> references = projDefinition
                .Element(msbuild + "Project")
                .Elements(msbuild + "ItemGroup")
                .Elements(msbuild + "Reference")
                .Elements(msbuild + "HintPath") 
                .Select(refElem => refElem.Value);
            _references.AddRange(references);

            foreach (string value in _references)
            {
                Console.WriteLine(value);
            }
        }

        public void BeautifyList()
        {
            Regex regex = new Regex(@".*\\(?<filename>[^\\]+\.dll)");
            foreach (string reference in _references)
            {
                string result = regex.Match(reference).Value;
                Console.WriteLine(result);

            }
        }

        public List<string> BeautifiedList => _beautifiedReferences;

        public List<string> ReferenceList => _references;
    }
}