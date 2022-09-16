using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}
