using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superai2
{
    class Function
    {
        String id;
        String name;
        Parameter toFind;
        Parameter[] fparams;

        public Function(String id, String name, Parameter toFind, Parameter[] fparams)
        {
            this.id = id;
            this.name = name;
            this.toFind = toFind;
            this.fparams = fparams;
        }

        public String Id { get { return id; } }
        public String Name { get { return name; } }
        public Parameter ToFind { get { return toFind; } }
        public Parameter[] Params { get { return fparams; } }
    }
}
