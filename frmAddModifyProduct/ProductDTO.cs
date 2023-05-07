using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportData
{
    // Product class without navigation property
    public class ProductDTO
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }       
        public decimal Version { get; internal set; }
        public DateTime ReleaseDate { get; internal set; }
        public object RealeseDate { get; internal set; }
    }
}
