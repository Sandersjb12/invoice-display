using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSproject3
{
    class InvoiceItem
    {
        private int productNumber;
        private string productDescription;
        private int quantity;
        private double unitPrice;
        private double totalPrice;

        public InvoiceItem(int number, string description, int q, double uPrice)
        {
            productNumber = number;
            productDescription = description;
            quantity = q;
            unitPrice = uPrice;
        }

        public int getProductNumber()
        {
            return productNumber;
        }

        public string getProductDescription()
        {
            return productDescription;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public double getTotal()
        {
            return totalPrice;
        }

        public void setProductNumber(int number)
        {
            productNumber = number;
        }

        public void setProductDescription(string description)
        {
            productDescription = description;
        }

        public void setQuantity(int q)
        {
            quantity = q;
        }

        public void setUnitPrice(int uPrice)
        {
            unitPrice = uPrice;
        }

        public string toString()
        {
            totalPrice = unitPrice * quantity;
            return String.Format("{0,3}{1,24}{2,13}{3,18:C2}{4,20:C2}",productNumber,productDescription,quantity,unitPrice,totalPrice);
        }
    }
}
