﻿namespace DreamHouse.Core.Domain.Entities
{
    public class ImprovementEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //NAV
        public ICollection<PropertyEntity> Properties { get; set; }
        public ICollection<ImprovementPropertyEntity> ImprovementProperties { get; set; }

    }
} 
