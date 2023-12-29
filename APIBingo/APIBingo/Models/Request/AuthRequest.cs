﻿using System.ComponentModel.DataAnnotations;

namespace APIBingo.Models.Request
{
    public class AuthRequest
    {
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }

        public bool Authentication() 
        {
            return true;
        }
    }
}