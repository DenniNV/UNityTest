using System.Text.RegularExpressions;
using System;

namespace UnitTestProject1
{
    class StringFormatter
    {

        public StringFormatter()
        {
            
        }
        public string WebString(string url)
        {
            if(url == null)
            {
                throw new NullReferenceException();
            }
            else if(url == "")
            {
                return "";
            }
            string _pattern = ".git$";
            if (Regex.IsMatch(url, _pattern))
            {
                return "git://" + url;
            }
            _pattern = "^http://";
            if (!Regex.IsMatch(url, _pattern))
            {
                return "http://" + url;
            }
            else return url;
            



        }



    }
}
