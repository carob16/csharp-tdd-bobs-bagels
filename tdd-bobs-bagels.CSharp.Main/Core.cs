using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    
    public class Core
    {   
        public Core(int capacity) { 
        
            _capacity = capacity;
        _basket = new string[capacity];


        }
        private int _capacity;
        private string[] _basket;

        public int Capacity {  get { return _capacity; }}
        public string[] Basket { get { return _basket; } set { _basket = value; } }
        
       
        public string[] addBagel(string bagel) {
            string[] bagels = new string[2];
            Basket.Append(bagel);
            return Basket;
        }

        public bool removeBagel() { throw new NotImplementedException(); }

        public string[] removeBagel(string bagel)
        {
            throw new NotImplementedException();
        }

        public int setCapacity(int limit)
        {
            throw new NotImplementedException();
        }

        public string checkLimit() { throw new NotImplementedException(); }

        public bool bagelIsInBasket(string bagelToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
