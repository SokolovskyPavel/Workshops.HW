﻿using System.Collections.Generic;

namespace Rocket.BL.Common.Models.ReleaseList
{
    public class Category
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Genre> ListGenre { get; set; }
    }
}
