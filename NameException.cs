using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstApp
{
    public class NameException
    {
        string name;
       public NameException(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name is required", nameof(name));
            }
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name is required", nameof(value));
                }

                name = value;
            }
        }
    }

}

