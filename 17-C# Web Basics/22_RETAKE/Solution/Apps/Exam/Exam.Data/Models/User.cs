﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Data.Models
{
    public class User
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
            //this = new HashSet<>();
            //this = new HashSet<>();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        //public virtual ICollection<>  { get; set; }

        //public virtual ICollection<>  { get; set; }
    }
}