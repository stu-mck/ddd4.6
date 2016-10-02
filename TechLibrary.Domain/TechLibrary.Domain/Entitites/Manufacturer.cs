using System;
using System.Collections.Generic;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entitites
{
    public  class Manufacturer : IEntity, IIndexable
    {

        public Manufacturer()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }

        public string Name { get; set; }

        public List<ModelFamily> ModelFamilies { get; set; }
    }
}
