using Atata;

namespace MistralQATask.Controls
{
    [ControlDefinition("li", ContainingClass = Constants.Controls.ProductItem)]
    public class ProductItem<TNavigateTo, TOwner> : Control<TOwner>
        where TNavigateTo : Page<TNavigateTo>
        where TOwner : PageObject<TOwner>
    {
        public Text<TOwner> Name { get; private set; }

        public LinkDelegate<TNavigateTo, TOwner> Item { get; private set; }
    }
}
