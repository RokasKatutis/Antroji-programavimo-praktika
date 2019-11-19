using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika
{
    public class Product
    {
        private string Name, Description, Photo, Tipas;
        private int Price;

        public Product()
        {

        }

        #region set
        public void SetName(string x)
        {
            Name = x;
        }
        public void SetDescription(string x)
        {
            Description = x;
        }
        public void SetPhoto(string x)
        {
            Photo = x;
        }
        public void SetTipas(string x)
        {
            Tipas = x;
        }
        public void SetPrice(int x)
        {
            Price = x;
        }
        #endregion


        #region get

        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public string GetPhoto()
        {
            return Photo;
        }
        public string GetTipas()
        {
            return Tipas;
        }
        public int GetPrice()
        {
           return Price;
            
        }

        #endregion

    }

}
