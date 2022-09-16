using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment : BaseModel
    {
        public int OrderId { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentStatusId { get; set; }
        public string Referrence { get; set; }
        public decimal Amount { get; set; }
    }
}
