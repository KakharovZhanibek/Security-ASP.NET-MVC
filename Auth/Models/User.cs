﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auth.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}