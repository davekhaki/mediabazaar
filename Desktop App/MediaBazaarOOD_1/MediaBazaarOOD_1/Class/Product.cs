using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarOOD_1.Class
{
    public class Product
    {
        //Fields
        private int productId;
        private string productName;
        private int productPrice;
        private string brand;
        private int productQuantity;
        private int minProductQuantity;
        public Product(string pName, int pPrice, string pBrand, int pQuantity)
        {
            this.ProductName = pName;
            this.ProductPrice = pPrice;
            this.Brand = pBrand;
            this.ProductQuantity = pQuantity;
          //  this.minProductQuantity = pMinimumQuantity;

        }

        public Product(int id,string pName, int pPrice, string pBrand, int pQuantity)
        {
            this.ProductId = id;
            this.ProductName = pName;
            this.ProductPrice = pPrice;
            this.Brand = pBrand;
            this.ProductQuantity = pQuantity;
            //  this.minProductQuantity = pMinimumQuantity;

        }
        public Product(int id)
        {
            this.ProductId = id;

        }

        public Product() { }

        public int ProductId
        {
            get { return this.productId; ; }
            set { this.productId = value; }
        }

        public string ProductName
        {
            get { return this.productName; }
            set { this.productName = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public int ProductPrice
        {
            get { return this.productPrice; }
            set { this.productPrice = value; }

        }
        public int ProductQuantity
        {
            get { return this.productQuantity; }
            set { this.productQuantity = value; }

        }
       // public int MinProductQuantity
      //  {
         //   get { return this.minProductQuantity; }
          //  set { this.minProductQuantity = value; }

      //  }

        public override String ToString()
        {
            return this.ProductName;
        }

    }
}
