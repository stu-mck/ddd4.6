using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entitites
{
    public class ModelFamily : IEntity, IIndexable
    {
        public ModelFamily()
        {
            ID = Guid.NewGuid();
        }

        public string Name { get; set; }

        public Guid ID { get; private set; }

        public List<Series> Series { get; set; }

        public Manufacturer Manufacturer { get; set; }


    }
}
