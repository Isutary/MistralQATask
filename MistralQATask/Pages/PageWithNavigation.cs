using Atata;

namespace MistralQATask.Pages
{
    public class PageWithNavigation<TOwner> : Page<TOwner>
        where TOwner : Page<TOwner>
    {
        [FindByClass(Constants.PageWithNavigation.ShoppingCart)]
        public LinkDelegate<ShoppingCartPage, TOwner> ShoppingCart { get; private set; }
    }
}
