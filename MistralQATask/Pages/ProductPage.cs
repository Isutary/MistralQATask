using Atata;
using MistralQATask.Attributes;

namespace MistralQATask.Pages
{
    using _ = ProductPage;

    public class ProductPage : PageWithNavigation<_>
    {
        [FindById(Constants.ProductPage.Add)]
        [WaitForNotification]
        public ButtonDelegate<_> Add { get; private set; }
    }
}
