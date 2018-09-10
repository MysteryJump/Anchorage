﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Text;
using System.Xml.Linq;

namespace Anchorage.Shared.Models
{
    public class Response : ClientResponse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        [ForeignKey("Thread")]
        public int ThreadId { get; set; }

        [Required]
        [JsonIgnore]
        public string HostAddress { get; set; }

        /// <summary>
        /// Initialize for write in database.
        /// </summary>
        /// <param name="threadId">Parent thread ID</param>
        /// <param name="host">Author host address</param>
        public void Initialize(int threadId, string host, string boardKey)
        {
            HostAddress = host;
            Created = DateTime.Now;
            ThreadId = threadId;
            Author = Models.Author.GenerateAuthorId(host, boardKey);
        }

    }

    public class ClientResponse
    {
        [Required]
        public string Body { get; set; }
        public string Mail { get; set; }
        public string Name { get; set; }
    }
}
