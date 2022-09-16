using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order : BaseModel
    {
        public int OrderNo { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public int OrderStatusId { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Total { get; set; }
    }
}
