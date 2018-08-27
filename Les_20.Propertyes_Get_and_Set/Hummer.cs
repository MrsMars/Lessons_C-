using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_20
{
    class Hummer
    {
        string material = null;

        public string Material
        {
            get
            {
                return material;
            }
            set
            {
                if (value.ToLower() != "metall")
                {
                    material = value;
                }
            }
        }
    }
}
