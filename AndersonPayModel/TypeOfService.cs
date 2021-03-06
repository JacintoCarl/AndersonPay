﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPayModel
{
    public class TypeOfService : Base.Base
    {
        public int TypeOfServiceId { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }

        public List<Service> Services { get; set; }
    }
}
