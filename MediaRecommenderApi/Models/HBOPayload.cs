﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class HBOPayload
    {
        public string UserId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
