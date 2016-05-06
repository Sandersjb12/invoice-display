using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSproject3
{
    class Invoice
    {
        private int invoiceNumber;
        private string customerName;
        private InvoiceItem[] items;
        private int index;
        private double extendedPrice;

        public Invoice()
        {
            invoiceNumber = -1;
            customerName = "";
            items = new InvoiceItem[10];
            index = 0;
            extendedPrice = 0;
        }

        public Invoice(int num, string name)
        {
            invoiceNumber = num;
            customerName = name;
            items = new InvoiceItem[10];
            index = 0;
            extendedPrice = 0;
        }

        public void setNumber(int num)
        {
            invoiceNumber = num;
        }

        public void setName(string name)
        {
            customerName = name;
        }

        public int getNumber()
        {
            return invoiceNumber;
        }

        public string getName()
        {
            return customerName;
        }

        public void addItem(InvoiceItem item)
        {
            if (index < 10)
            {
                items[index] = item;
                index++;
            }
        }

        public void printInvoice()
        {
            Console.WriteLine("Invoice Number: {0}", invoiceNumber);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("====");
            Console.WriteLine("Product Number\tDescription\tQuantity\tUnit Price\tExtended Price");
            Console.WriteLine("====");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(items[i].toString());
                extendedPrice += items[i].getTotal();
            }

            Console.WriteLine("====");
            Console.WriteLine("Invoice Total: {0:C2}", extendedPrice);
        }
    }
}
