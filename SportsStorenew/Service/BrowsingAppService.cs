using SportsStorenew.Domain.DB;
using SportsStorenew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStorenew.Service
{
    public class BrowsingAppService : IBrowsingAppService
    {
        SportsStoreDbContext _dbContext;
        public BrowsingAppService(SportsStoreDbContext dbcontext)
        {
            this._dbContext = dbcontext;
        }
        public GetCategoriesResponse GetCategories(GetCategoriesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetProductsReasponse GetProducts(GetProductsRequest request)
        {
            var filterProducts = _dbContext.Products.
                Where(p => p.Category.Name == request.CategoryName || request.CategoryName == null);
            var totalCount = filterProducts.Count();
            var result = filterProducts.
                Skip(request.PageSize * (request.Page - 1)).
                Take(request.PageSize).
                Select(p => new GetProductsReasponse.Product
                {
                    Name = p.Name,
                    ProductId =p.ProductId,
                    Price = p.Price,
                    ThumbnailUrl=p.Images.SingleOrDefault(i=>i.IsThumbnail).ImageUrl

                });
            return new GetProductsReasponse
            {
                Products = result.ToList(),
                PageSize = request.PageSize,
                Page = request.Page,
                TotalCount = totalCount
            };
        }
    }
}
