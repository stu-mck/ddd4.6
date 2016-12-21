
using TechLibrary.Domain.Aggregagtes;
using Xunit;


namespace TechLibrary.UnitTests
{
    
    public class MakeAggregateTests
    {
        [Fact]
        public void CanAddModelToManufacturer()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            Assert.Equal(1, man.ModelFamilies.Count);
            Assert.Equal(mod.Name, man.ModelFamilies[0].Name);

        }

        [Fact]
        public void CanAddSeriesToExistingModel()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            var newSeries = man.AddSeriesToModel(mod.ID, "XA", 1972, 1974);

            Assert.Equal(newSeries.Name, man.ModelFamilies[0].Series[0].Name);
            Assert.Equal(newSeries.YearFrom, man.ModelFamilies[0].Series[0].YearFrom);
            Assert.Equal(newSeries.YearTo, man.ModelFamilies[0].Series[0].YearTo);

        }

        [Fact]
        public void CanAddMultipleModelsWithSameName()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");
            var modx = man.AddModel("falcon");

            Assert.Equal(2, man.ModelFamilies.Count);

        }

        [Fact]
        public void CanAddMultipleSeriesWithSameName()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            var newSeries = man.AddSeriesToModel(mod.ID, "XA", 1972, 1974);
            var newSeries2 = man.AddSeriesToModel(mod.ID, "XA", 1977, 1979);

            Assert.Equal(2, man.ModelFamilies[0].Series.Count);

        }

        [Fact]
        public void CanFindModelByName()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            var results = man.GetModelFamilyByName("falcon");

            Assert.NotNull(results);
            Assert.Equal(1, results.Count);
            Assert.Equal("falcon", results[0].Name);
        }

        [Fact]
        public void CanFindModelByID()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            var results = man.GetModelFamilyByID(mod.ID);

            Assert.NotNull(results);
            Assert.Equal("falcon", results.Name);
        }


        private Make SetUpManufacturer()
        {
            var man = new Make();

            var mod = man.AddModel("falcon");

            return man;
        }
    }
}
