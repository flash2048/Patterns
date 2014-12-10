using System;
using System.Collections.Generic;

namespace SingletonPattern.Session
{
    sealed class MySession
    {
        private static MySession _session;
        private readonly DateTime _date;
        private readonly Dictionary<string, string> _dictionary;

        private MySession()
        {
            _date = DateTime.Now;
            _dictionary = new Dictionary<string, string>();
        }

        public static MySession Instance
        {
            get { return _session ?? (_session = new MySession()); }
        }

        public DateTime DateStart
        {
            get { return _date; }
        }
        public String this[String key]
        {
            get { return _dictionary.ContainsKey(key) ? _dictionary[key] : ""; }
            set
            {
                if (_dictionary.ContainsKey(key))
                {
                    _dictionary[key] = value;
                }
                else
                {
                    _dictionary.Add(key, value);
                }
            }
        }
    }
}
