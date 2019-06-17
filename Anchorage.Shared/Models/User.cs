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
        public string Password { get; set; }

        public string UserId { get; set; }
        [JsonIgnore]
        [Required]
        public string Id { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
