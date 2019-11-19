using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    class Order
    {
        private string Name, Surname, Phone, Address, WOrder;

        #region SET

        public void SetName(string x)
        {
            Name = x;
        }

        public void SetSurname(string x)
        {
            Surname = x;
        }

        public void SetPhone(string x)
        {
            Phone = x;
        }

        public void SetAddress(string x)
        {
            Address = x;
        }

        public void SetWOrder(string x)
        {
            WOrder = x;
        }

        #endregion

        #region GET

        public string GetName()
        {
            return
               Name;
        }

        public string GetSurname()
        {
            return
               Surname;
        }

        public string GetPhone()
        {
            return
               Phone;
        }

        public string GetAddress()
        {
            return
               Address;
        }

        public string GetWOrder()
        {
            return
               WOrder;
        }

        #endregion
    }
}
