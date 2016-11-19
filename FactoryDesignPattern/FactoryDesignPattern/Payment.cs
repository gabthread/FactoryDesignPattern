using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TypeId { get; set; }
        public IPaymentType Type { get; set; }
    }
}
