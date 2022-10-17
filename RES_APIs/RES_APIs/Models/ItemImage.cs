﻿using System.ComponentModel.DataAnnotations;

namespace RES_APIs.Models
{
    public class ItemImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
    }
}
