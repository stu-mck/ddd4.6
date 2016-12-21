using System;
using TechLibrary.Domain.Aggregates;
using Xunit;



namespace TechLibrary.UnitTests
{
    
    public class ArticleDefinitionTests
    {
        [Fact]
        public void CanAddNewSectionToDefintion()
        {
            var ad = new ArticleDefinition(Guid.NewGuid());

            ad.AddSection("something", 22);

            Assert.Equal(1, ad.Sections.Count);
            Assert.Equal("something", ad.Sections[0].Name);
            Assert.Equal(22, ad.Sections[0].Order);

        }

        [Fact]
        public void CanAddIndexToExistingSection()
        {
            var ad = new ArticleDefinition(Guid.NewGuid());

            ad.AddSection("something", 22);

            ad.AddIndex("something", new ContentIndex(null, null));

            Assert.Equal(1, ad.Sections[0].Indexes.Count);

        }
    }
}
