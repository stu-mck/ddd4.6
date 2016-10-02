using System;
using TechLibrary.Domain.Aggregagtes;
using TechLibrary.Domain.Values;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entities
{
    public class Engine : IEntity, IIndexable
    {
        public Engine()
        {
            ID = Guid.NewGuid();
        }
        public Guid ID { get; private set; }

        public Manufacturer Manufacturer { get; set; }

        public int Capacity { get; set; }

        public FuelType FuelType { get; set; }
    }
}
