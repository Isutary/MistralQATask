using Atata;
using MistralQATask.Controls;

namespace MistralQATask.Pages
{
    using _ = ShoppingCartPage;

    public class ShoppingCartPage : PageWithNavigation<_>
    {
        [FindByClass(Constants.ShoppingCartPage.Table)]
        public Table<ProductTableRow<_>, _> Products { get; private set; }
    }
}
