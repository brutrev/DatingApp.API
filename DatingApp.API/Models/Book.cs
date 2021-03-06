﻿using DatingApp.API.Models.Base;

namespace DatingApp.API.Models
{
    public class Book : BaseModel
    {
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
