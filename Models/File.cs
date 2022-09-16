using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class File : BaseModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
        public int EntityId { get; set; }
        public string Base64Data { get; set; }
    }
}
