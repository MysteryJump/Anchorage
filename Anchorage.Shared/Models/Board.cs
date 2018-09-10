﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anchorage.Shared.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BoardKey { get; set; }
        [Required]
        public string BoardName { get; set; }
        [NotMapped]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Thread> Child { get; set; }
        [Required]
        public string BoardDefaultName { get; set; }
        
    }
}
