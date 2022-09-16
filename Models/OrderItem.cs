using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItem : BaseModel
    {
        public int Qty { get; set; }
        public Decimal Price { get; set; }
    }
}
