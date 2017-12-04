using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace punyreferences
{
    public class DLLParser
    {
        private List<string> _dllList = new List<string>();
        private List<string> _beautifiedList = new List<string>();

        public void ParseFiles(string rootPath)
        {
            _dllList = Directory.GetFiles(rootPath, "*.dll", SearchOption.AllDirectories).ToList();
        }

        public void BeautifyList()
        {
            foreach (var file in _dllList)
            {
                
            }
        }

        public List<string> DllList => _dllList;
        public List<string> BeautifiedList => _beautifiedList;
    }
}