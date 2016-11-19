using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PaymentFactory
    {
        public static IPaymentType GetPaymentType(int paymentTypeId)
        {
            switch (paymentTypeId)
            {
                case 0:
                    return new CardPayment();
                case 1:
                    return new PaypalPayment();
                default:
                    return new CardPayment();
            }
        }
    }
}
