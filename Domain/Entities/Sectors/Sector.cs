using Domain.Entities.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Sectors
{
    public class Sector
    {
        [Key]
        public Guid SectorId { get; init; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Item>? items { get; set; }
    }
}
