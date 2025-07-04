﻿using Domain.Entities.Sectors;
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

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(100)]
        public string? Description { get; set; }

        public DateTime CreateAt { get; init; }

        public DateTime UpdateAt { get; set; }

        public Guid? SectorId { get; set; }
        public Sector? Sector { get; set; }
    }
}
