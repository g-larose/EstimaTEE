using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.Models
{
    public class Item
    {
        [Key]
        public Guid Id  { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice? Invoice { get; set; }
        public virtual ICollection<EstimaTEE.Models.Attribute>? Attributes { get; set; }
    }
}
