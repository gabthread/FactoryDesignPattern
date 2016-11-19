using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CardPayment : IPaymentType
    {
        
        bool IPaymentType.IsValidPayment()
        {
            Console.WriteLine("Card Payment Valid");
            return true;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Card Payment Processed");            
        }
    }
}
