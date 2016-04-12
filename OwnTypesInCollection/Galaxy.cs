using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnTypesInCollection
{
    class Galaxy
    {
        public string Name { get; set; }
        public int LightYears { get; set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
