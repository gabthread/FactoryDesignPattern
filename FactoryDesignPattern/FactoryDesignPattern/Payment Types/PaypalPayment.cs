using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PaypalPayment : IPaymentType
    {
        bool IPaymentType.IsValidPayment()
        {
            Console.WriteLine("Paypal Payment Valid");
            return true;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Paypal Payment Processed");
        }
    }
}
