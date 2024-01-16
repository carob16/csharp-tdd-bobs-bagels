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
            _basket = new List<string>();

        }
        private int _capacity;
        private List<string> _basket;

        public int Capacity {  get { return _capacity; }}
        public List<string> Basket { get { return _basket; } set { _basket = value; } }
        
       
        public List<string> addBagel(string bagel) {

            bool FreeCapacity = checkBasketLimit();
            if (FreeCapacity){
                Basket.Add(bagel);
                }
            return Basket;
        }

        public bool removeBagel() { throw new NotImplementedException(); }

        public List<string> removeBagel(string bagel)
        {
            if (bagelIsInBasket(bagel).Value) { Basket.Remove(bagel);  }

            return Basket;
        
        }

        public int setCapacity(int limit)
        {
            _capacity = limit;
           
            return _capacity;
        }

        public bool checkBasketLimit() {
            bool permissionToAdd;
            int currentStatus = Basket.Count;

            if (currentStatus >= Capacity)
            {
                permissionToAdd = false;
            }
            else
            {
                permissionToAdd = true;
            }
            
            return permissionToAdd;
        }

        public KeyValuePair<string,bool> bagelIsInBasket(string bagelToRemove)
        {
            if (Basket.Contains(bagelToRemove))
            {
                return KeyValuePair.Create(bagelToRemove, true);
            }
            else
            {
                return KeyValuePair.Create("Bagel does not exist in bag", false);
            }
           
        }
    }
}
