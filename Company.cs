using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSproject3
{
    class Company
    {
        static void Main(string[] args)
        {
            Invoice[] invoices = new Invoice[100];

            invoices[0] = new Invoice(1, "James Bond");
            invoices[0].addItem(new InvoiceItem(83,"Electric Sander",7,67.98));
            invoices[0].addItem(new InvoiceItem(24,"Power Saw",18,89.99));
            invoices[0].addItem(new InvoiceItem(7, "Charger", 11, 23.5));

            invoices[1] = new Invoice(2, "Ethan Hunt");
            invoices[1].addItem(new InvoiceItem(77,"Hammer",76,12.99));
            invoices[1].addItem(new InvoiceItem(39,"Lawn Mower",3,76.50));
            invoices[1].addItem(new InvoiceItem(68,"Screwdriver",106,9.99));
            invoices[1].addItem(new InvoiceItem(45,"Nail-3mm",1000,.05));

            invoices[2] = new Invoice(3, "Ethan Hunt");
            invoices[2].addItem(new InvoiceItem(83, "Electric Sander", 11, 67.98));
            invoices[2].addItem(new InvoiceItem(24, "Power Saw", 28, 89.99));
            invoices[2].addItem(new InvoiceItem(7, "Charger", 21, 23.5));

            invoices[0].printInvoice();
            Console.WriteLine();
            invoices[1].printInvoice();
            Console.WriteLine();
            invoices[2].printInvoice();

            Console.ReadLine();
        }
    }
}
