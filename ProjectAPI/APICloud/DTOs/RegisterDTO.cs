﻿using System.ComponentModel.DataAnnotations;

namespace APICloud.DTOs
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
