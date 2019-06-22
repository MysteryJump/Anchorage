﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Anchorage.Shared.Models
{
    public class User
    {
        [NotMapped]
        [JsonRequired]
        public string Password { get; set; }

        [Required]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonIgnore]
        [Required]
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }
        [JsonIgnore]
        public UserAuthority Authority { get; set; }
    }

    [Flags]
    public enum UserAuthority
    {
        Normal = 1,
        Admin = 1 << 1,
        Restricted = 1 << 2
    }
}
