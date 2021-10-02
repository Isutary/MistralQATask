using Atata;

namespace MistralQATask.Controls
{
    public class ProductTableRow<TOwner> : TableRow<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindByClass(Constants.Controls.Product)]
        public Clickable<TOwner> Product { get; private set; }
    }
}
