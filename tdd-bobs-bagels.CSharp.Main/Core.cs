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
        private int _capacity = 2;
        private string[] _basket = new string[2];

        public int Capacity {  get { return _capacity; }}
        public string[] Basket { get { return _basket; } }
        
       
        public string[] addBagel(string bagel) {
            throw new NotImplementedException();
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
