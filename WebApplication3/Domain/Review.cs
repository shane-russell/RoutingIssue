﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication3
{
    public class Review
    {
        public int Id { get; set; }

        // [Range(1, 10)]
        public int Rating { get; set; }

        public string Body { get; set; }

        public int RestaurantId { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        // [Required]
        public string ReviewerName { get; set; }
    }
}
