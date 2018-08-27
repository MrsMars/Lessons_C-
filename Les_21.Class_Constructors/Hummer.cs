using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_21
{
    class Hummer
    {
        string firm = null;

        public string Firm
        {
            get
            {
                return firm;
            }
            set
            {
                firm = value;
            }
        }

        public string material = null;
        public int weight;
        public int price;

        #region Constructors
        // при создании пользовательского конструктора, нужно обязательно задать конструктор по умолчанию 

        // Default constructor
        public Hummer() { }

        // User's constructor 1
        public Hummer(string firm)
        {
            Firm = firm;
        }

        // User's constructor 2
        public Hummer(string firm, string material, int weight)
        {
            Firm = firm;
            this.material = material;
            this.weight = weight;
        }

        // User's constructor 3
        public Hummer(int price) : this("SomeFirm", "SomeMaterial", 2) // программа подберёт конструктор с подходящими входными параметрами в 'this'
        {
            this.price = price;

        }
        


        #endregion
    }
}
