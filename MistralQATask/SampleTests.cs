using Atata;
using MistralQATask.Pages;
using NUnit.Framework;

namespace MistralQATask
{
    public class SampleTests : UITestFixture
    {
        [Test]
        public void SampleTest()
        {
            Go.To<HomePage>()
                .Search.Set("Apple")
                .SearchResults[x => x.Name == "Apple MacBook Pro 13-inch"].ClickAndGo<ProductPage>()
                .Add()
                .ShoppingCart()
                .Products.Rows[0].Product.Content.Should.Equal("Apple MacBook Pro 13-inch");
        }
    }
}
