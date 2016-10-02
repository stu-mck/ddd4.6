using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechLibrary.Domain.Aggregates;

namespace TechLibrary.UnitTests
{
    [TestClass]
    public class ArticleDefinitionTests
    {
        [TestMethod]
        public void CanAddNewSectionToDefintion()
        {
            var ad = new ArticleDefinition(Guid.NewGuid());

            ad.AddSection("something", 22);

            Assert.AreEqual(1, ad.Sections.Count);
            Assert.AreEqual("something", ad.Sections[0].Name);
            Assert.AreEqual(22, ad.Sections[0].Order);

        }

        [TestMethod]
        public void CanAddIndexToExistingSection()
        {
            var ad = new ArticleDefinition(Guid.NewGuid());

            ad.AddSection("something", 22);

            ad.AddIndex("something", new ContentIndex(null, null));

            Assert.AreEqual(1, ad.Sections[0].Indexes.Count);

        }
    }
}
