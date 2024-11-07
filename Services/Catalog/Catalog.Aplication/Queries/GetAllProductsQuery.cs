using Catalog.Application.Responses;
using Catalog.Core.Specs;
using MediatR;  

namespace Catalog.Application.Queries
{
    public class GetAllProductsQuery : IRequest<Pagination<ProductResponse>>
    {
        public CatalogSpecParams CatalogSpecParams { get; private set; }
        public GetAllProductsQuery(CatalogSpecParams catalogSpecParams )
        {
            CatalogSpecParams = catalogSpecParams;
        }
      
    }
}
