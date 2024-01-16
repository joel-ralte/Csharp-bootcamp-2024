using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_1
{
    internal class Product
    {
        internal Product() { }
        internal Product(int Id, string Name, DateTime MfgDate, string Warranty, double Price, int Stock, int GST, int Discount) : this()
        {
            ProdId = Id;
            ProdName = Name;
            ProdMfgDate = MfgDate;
            ProdWarranty = Warranty;
            ProdPrice = Price;
            ProdStock = Stock;
            ProdGST = GST;
            ProdDiscount = Discount;
        }

        private int m_ProdId;

        public int ProdId
        {
            get { return m_ProdId; }
            set
            {
                if (value > 0)
                    m_ProdId = value;
                else
                    throw new Exception("Invalid ProdId");
            }
        }

        private string m_ProdName;

        public string ProdName
        {
            get { return m_ProdName; }
            set
            {
                if (value.Length > 3)
                    m_ProdName = value;
                else
                    throw new Exception("Name should be atleast 3 chars");
            }
        }

        private DateTime m_ProdMfgDate;

        public DateTime ProdMfgDate
        {
            get { return m_ProdMfgDate; }
            set
            {
                if (value < DateTime.Today)
                    m_ProdMfgDate = value;
                else
                    throw new Exception("Invalid manufacturing date");
            }
        }

        private string m_ProdWarranty;

        public string ProdWarranty
        {
            get { return m_ProdWarranty; }
            set { m_ProdWarranty = value; }
        }

        private double m_ProdPrice = 0;

        public double ProdPrice
        {
            get { return m_ProdPrice; }
            set
            {
                if (value > 0)
                    m_ProdPrice = value;
                else
                    throw new Exception("Price has to be greater than zero");
            }
        }

        private int m_ProdStock;

        public int ProdStock
        {
            get { return m_ProdStock; }
            set
            {
                if (value == 5 || value == 12 || value == 18 || value == 28)
                    m_ProdStock = value;
                else
                    throw new Exception("Stock value must be either 5,12,18 or 28");
            }
        }

        private int m_ProdGST;

        public int ProdGST
        {
            get { return m_ProdGST; }
            set
            {
                if (value > 0 && value < 31)
                    m_ProdGST = value;
                else
                    throw new Exception("GST value must be between 1 and 30");
            }
        }

        private int m_ProdDiscount;

        public int ProdDiscount
        {
            get { return m_ProdDiscount; }
            set
            {
                if (value >= 0 && value <= 100)
                    m_ProdDiscount = value;
                else
                    throw new Exception("Discount value must be between 1 and 100");
            }
        }

        public string Display()
        {
            double ProdTaxPrice = ProdPrice + (ProdPrice * ProdGST / 100);
            double ProdDiscountPrice = ProdTaxPrice * ProdDiscount;
            double ProdTotalPrice = ProdDiscountPrice * ProdStock;

            StringBuilder sb = new StringBuilder();
            sb.Append("Product Name: " + ProdName + "\n");
            sb.Append("Product MfgDate: " + ProdMfgDate.ToLongDateString() + "\n");
            sb.Append("Product TaxPrice: " + ProdTaxPrice + "\n");
            sb.Append("Product DiscountPrice: " + ProdDiscountPrice + "\n");
            sb.Append("Product TotalPrice: " + ProdTotalPrice + "\n");
            return sb.ToString();
        }

    }
}
