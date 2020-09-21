using System;

namespace ClassLibrary1
{
    public class Sum
    {
        private string a;
        private string b;

        public Sum(string a, string b)
        {
            this.a = a;
            this.b = b;
        }

        public string summa ()
        {       
            return "" + (Int32.Parse(a) + Int32.Parse(b));
        }
        
        public string summa (string c)
        {       
            return "" + (Int32.Parse(a) + Int32.Parse(b)+ Int32.Parse(c));
        }

    }
}
