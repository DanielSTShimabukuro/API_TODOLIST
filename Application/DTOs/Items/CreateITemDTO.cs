﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Items
{
    public class CreateITemDTO
    {
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? Description { get; set; }
    }
}
