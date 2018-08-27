using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_19
{
    class Hummer
    {
        string material = null;

        public string GetField()        // getter
        {
            return material;
        }

        public bool SetField(string material)   // setter
        {
            if (material.ToLower() != "metall")
            {
                this.material = material;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
