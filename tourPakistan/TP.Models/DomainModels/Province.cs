﻿using System.Collections.Generic;

namespace TP.Models.DomainModels
{
    public class Province
    {
        public Province()
        {
            this.Locations = new HashSet<Location>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string RecCreatedBy { get; set; }
        public System.DateTime RecCreatedDate { get; set; }
        public string RecLastUpdatedBy { get; set; }
        public System.DateTime RecLastUpdatedDate { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
