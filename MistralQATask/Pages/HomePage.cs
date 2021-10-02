using Atata;
using MistralQATask.Controls;

namespace MistralQATask.Pages
{
    using _ = HomePage;

    public class HomePage : PageWithNavigation<_>
    {
        [FindById(Constants.HomePage.Search)]
        public TextInput<_> Search { get; private set; }

        [WaitFor]
        public ControlList<ProductItem<ProductPage, _>, _> SearchResults { get; private set; }
    }
}
