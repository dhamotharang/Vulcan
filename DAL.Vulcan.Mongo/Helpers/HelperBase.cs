﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Vulcan.Mongo.Base.Logger;

namespace DAL.Vulcan.Mongo.Helpers
{
    public class HelperBase
    {
        public VulcanLogger Logger { get; set; } = new VulcanLogger();
    }
}
