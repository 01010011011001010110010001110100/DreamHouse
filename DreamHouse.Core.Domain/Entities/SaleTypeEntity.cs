﻿namespace DreamHouse.Core.Domain.Entities
{
    public class SaleTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //NAV
        public ICollection<PropertyEntity>? Properties { get; set; }
    }
}