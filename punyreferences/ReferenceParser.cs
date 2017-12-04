using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

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
            Console.WriteLine(filePath);
        }


        public List<string> ReferenceList => _references;
    }
}