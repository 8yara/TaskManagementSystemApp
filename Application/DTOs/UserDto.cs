﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
