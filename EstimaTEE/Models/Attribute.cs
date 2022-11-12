using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.Models
{
    public class Attribute
    {
        [Key]
        public Guid Id { get; set; }
        public string AttrName { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public Guid ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
