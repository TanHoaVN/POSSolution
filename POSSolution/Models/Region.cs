﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POSSolution.Application.Models
{
    public class Region
    {
        public Guid regionId { get; set; }

        public string name { get; set; }
        
        public string code {get; set; }

        public Shop shop { get; set; }

        public ICollection<Table> tables { get; set; }

        public string createUser { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? updateDate { get; set; }
    }
}
