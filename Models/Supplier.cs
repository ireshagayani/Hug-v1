using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Address Address { get; set; }
        public IList<Contact> Contacts { get; set; }
    }
}
