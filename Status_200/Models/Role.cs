﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Status_200.Models
{
    public class Role
    {
        [Key]
        public byte Id { get; set; }
        public string RoleName { get; set; }
    }
}
