using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Basket : Product // paveldėjimas
    {
        //inkapsuliacija, jeigu klase(basket) kvieciama kitoje klaseje, tai ID nematysim jeigu norim nustatyt ID reiksme reikia naudoti get/set metodus
        private int ID;

        public Basket()
        {

        }
        //inkapsuliacijos
        public void setID(int x) 
        {
            ID = x;
        }

        public int getID()
        {
            return ID;
        }
    }
}
