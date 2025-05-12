using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Items
{
    public class Item
    {
        [Key]
        public Guid Id { get; init; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }

        public DateTime CreateAt { get; init; }

        public DateTime UpdateAt { get; set; }

        public Item()
        {

        }
    }
}
