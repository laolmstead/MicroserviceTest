using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materials.Contracts.Materials
{
    public class CreateMaterialRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string? Unit { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
