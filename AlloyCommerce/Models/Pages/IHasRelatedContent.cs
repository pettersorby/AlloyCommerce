using EPiServer.Core;

namespace AlloyCommerce.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
