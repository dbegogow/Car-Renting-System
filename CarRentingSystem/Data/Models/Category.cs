﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using static CarRentingSystem.Data.DataConstants.Category;

namespace CarRentingSystem.Data.Models
{
    public class Category
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; init; }

        public IEnumerable<Car> Cars { get; init; } = new HashSet<Car>();
    }
}
