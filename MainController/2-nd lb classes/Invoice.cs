using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainController._2_nd_lb_classes
{
    class Invoice
    {
        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public int Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }

        string _article;
        int _quality;

        const double tax = 20; // НДС - 20%

        public void Price()
        {

        }

    }
}
