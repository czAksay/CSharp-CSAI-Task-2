using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superai2
{
    class Parameter
    {
        int num;
        String id;
        String name;
        double val;
        //bool tmpval;

        public Parameter(int num, String id, String name)
        {
            this.num = num;
            this.id = id;
            this.name = name;
            Found = false;
        }

        public int Num { get { return num; } }
        public String Id { get { return id; } }
        public String Name { get { return name; } }
        public bool Remember { get; set; }
        public double Value { get { return val; }
            set
            {
                val = value;
                SetFound();
            }
        }

        public void SetFound()
        {
            if (Remember)
                Found = true;
            else
                TempFound = true;
        }

        public bool Found { get; set; }
        public bool TempFound { get; set; }
        //public bool Defined { get; set; }
    }
}
