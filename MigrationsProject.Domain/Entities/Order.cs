﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MigrationsProject.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        [Required, StringLength(50)]
        public string Number { get; set; }

        public DateTime CreatedAtUtc { get; set; }
    }
}
