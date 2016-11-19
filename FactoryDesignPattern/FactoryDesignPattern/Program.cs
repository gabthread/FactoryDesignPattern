using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //we assumed that  for example the payment type was selected by the user in runtime
            var payment = new Payment()
            {
                Id = 1,
                Date = DateTime.Now,
                TypeId = 1 //paypal           
            };

            //Get the correct Payment Type instance in runtime
            payment.Type = PaymentFactory.GetPaymentType(payment.TypeId);

            payment.Type.IsValidPayment();
            payment.Type.ProcessPayment();
            Console.ReadLine();

        }
    }
}
