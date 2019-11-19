using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Basket : Product
    {
        private int ID;

        public Basket()
        {

        }

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
