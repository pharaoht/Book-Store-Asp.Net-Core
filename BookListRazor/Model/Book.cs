﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key] //key will automatically add Id as an Identity column, so we wont have to pass the value
        public int Id { get; set; }

        [Required] //means this property cannot be null
        public string Name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
