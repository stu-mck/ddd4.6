﻿using System;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entities
{
    public class Series : IEntity, IIndexable
    {
        public Series()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
        public string Name { get; set; }
        public int YearFrom { get; set; }
        public int YearTo { get; set; }
        public Model Model { get; set; }
    }
}
