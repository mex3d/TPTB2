﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPTB2.Shared.Domain
{
    public class Payment: BaseDomainModel
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public float SecurityCode { get; set; }
    }
}
