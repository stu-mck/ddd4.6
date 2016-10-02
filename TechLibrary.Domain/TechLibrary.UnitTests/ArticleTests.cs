using System;
using TechLibrary.Domain.Aggregates;
using Xunit;

namespace TechLibrary.UnitTests
{
   
    public class ArticleTests
    {
        [Fact]
        public void SectionCanBeAddedToAnArticle()
        {
            var a = new ArticleDefinition(Guid.NewGuid());

            a.AddSection("xxx", 22);

            Assert.Equal(1, a.Sections.Count);
            Assert.Equal("xxx", a.Sections[0].Name);
            Assert.Equal(22, a.Sections[0].Order);
        }
    }
}
