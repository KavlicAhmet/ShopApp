﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }

        [Required(ErrorMessage = "ProductName is required!")]
        public string? ProductName { get; init; } = string.Empty;

        [Required(ErrorMessage = "Price is required!")]
        public decimal Price { get; init; }
        public string? Summary { get; init; } = string.Empty;
        public string? ImageUrl { get; set; }
        public int? CategoryId { get; init; }
    }
}
