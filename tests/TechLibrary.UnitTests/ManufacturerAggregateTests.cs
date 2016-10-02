using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechLibrary.Domain.Aggregagtes;

namespace TechLibrary.UnitTests
{
    [TestClass]
    public class ManufacturerAggregateTests
    {
        [TestMethod]
        public void CanAddModelToManufacturer()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            Assert.AreEqual(1, man.ModelFamilies.Count);
            Assert.AreEqual(mod.Name, man.ModelFamilies[0].Name);

        }

        [TestMethod]
        public void CanAddSeriesToExistingModel()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            var newSeries = man.AddSeriesToModel(mod.ID, "XA", 1972, 1974);

            Assert.AreEqual(newSeries.Name, man.ModelFamilies[0].Series[0].Name);
            Assert.AreEqual(newSeries.YearFrom, man.ModelFamilies[0].Series[0].YearFrom);
            Assert.AreEqual(newSeries.YearTo, man.ModelFamilies[0].Series[0].YearTo);

        }

        [TestMethod]
        public void CanAddMultipleModelsWithSameName()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");
            var modx = man.AddModel("falcon");

            Assert.AreEqual(2, man.ModelFamilies.Count);

        }

        [TestMethod]
        public void CanAddMultipleSeriesWithSameName()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            var newSeries = man.AddSeriesToModel(mod.ID, "XA", 1972, 1974);
            var newSeries2 = man.AddSeriesToModel(mod.ID, "XA", 1977, 1979);

            Assert.AreEqual(2, man.ModelFamilies[0].Series.Count);

        }

        [TestMethod]
        public void CanFindModelByName()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            var results = man.GetModelFamilyByName("falcon");

            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("falcon", results[0].Name);
        }

        [TestMethod]
        public void CanFindModelByID()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            var results = man.GetModelFamilyByID(mod.ID);

            Assert.IsNotNull(results);
            Assert.AreEqual("falcon", results.Name);
        }


        private Manufacturer SetUpManufacturer()
        {
            var man = new Manufacturer();

            var mod = man.AddModel("falcon");

            return man;
        }
    }
}
