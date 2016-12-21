using System;
using System.Collections.Generic;
using TechLibrary.Domain.Aggregagtes;
using TechLibrary.Interfaces;

namespace TechLibrary.Domain.Entities
{
    public class Model : IEntity, IIndexable
    {
        public Model()
        {
            ID = Guid.NewGuid();
            Series = new List<Series>();
        }

        public string Name { get; set; }

        public Guid ID { get; private set; }

        public List<Series> Series { get; set; }

        public Make Make { get; set; }

        public Series AddSeries(string name, int yearFrom, int yearTo)
        {
            var series = new Series()
            {
                Name = name,
                YearFrom = yearFrom,
                YearTo = yearTo
            };
            Series.Add(series);
            return series;
        }
    }
}
