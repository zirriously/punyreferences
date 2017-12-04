using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
            Regex regex = new Regex(@"[^\\]+\.dll");
            foreach (string file in _dllList)
            {
                string result = regex.Match(file).Value;
                BeautifiedList.Add(result);
            }
            Console.WriteLine(_beautifiedList.Count);
        }

        public List<string> DllList => _dllList;
        public List<string> BeautifiedList => _beautifiedList;
    }
}