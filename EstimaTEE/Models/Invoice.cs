using EstimaTEE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimaTEE.Models
{
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Creator { get; set; } = string.Empty;
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset DueDate { get; set; }
        public Status Status { get; set; }
        public Guid CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Item>? Items { get; set; }

    }
}
