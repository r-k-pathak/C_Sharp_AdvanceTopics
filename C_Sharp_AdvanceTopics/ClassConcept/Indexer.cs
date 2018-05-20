using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_AdvanceTopics.ClassConcept
{
    class Indexer
    {
        public Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        //if you want use class have behaviour of Type like Dictionary or any other collection 
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }


    }
    
}
