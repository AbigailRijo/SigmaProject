﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Data.Models
{
    public class RoomType : BaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        
    }
}