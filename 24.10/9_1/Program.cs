﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace UnitTestApp.Models

{

    public class User

    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }

    }
}