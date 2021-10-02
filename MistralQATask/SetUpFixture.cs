using Atata;
using NUnit.Framework;

namespace MistralQATask
{
    [SetUpFixture]
    public class SetUpFixture
    {
        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("https://demo.nopcommerce.com/")
                .UseCulture("en-US")
                .UseAllNUnitFeatures()
                .AddScreenshotFileSaving()
                    .WithArtifactsFolderPath();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }
    }
}
