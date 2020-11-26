using SportsStoreNew.Domain.DB;
using SportsStoreNew.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreNew.Service
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
        public GetProductDetails GetProduct(int Id)
        {
            return new GetProductDetails
            {
                ProductName = _dbContext.Products.Where(a => a.ProductId == Id).Select(a => a.Name).FirstOrDefault(),
                Description = _dbContext.Products.Where(a => a.ProductId == Id).Select(a => a.Description).FirstOrDefault(),
                ProductPrice = _dbContext.Products.Where(a => a.ProductId == Id).Select(a => a.Price).FirstOrDefault(),
                DetailsImageUrl = _dbContext.ProductImages.Where(a => a.ProductId == Id).Select(a => a.ImageUrl).FirstOrDefault()
            };
        }
        public GetProductsReasponse GetProducts(GetProductsRequest request)
        {
            var filterProducts = _dbContext.Products.
                Where(p => (p.Category.Name == request.CategoryName || request.CategoryName == null) &&
                (p.Name.Contains(request.Name) || request.Name==null)); 
                
            var totalCount = filterProducts.Count();
            var result = filterProducts.
                Skip(request.PageSize * (request.Page - 1)).
                Take(request.PageSize).
                Select(p => new GetProductsReasponse.Product
                {
                    Name = p.Name,
                    ProductId =p.ProductId,
                    Price = p.Price,
                    ThumbnailUrl=p.Images.SingleOrDefault(i=>i.IsThumbnail).ImageUrl,
                    CategoryId=p.CategoryId,
                    DiscountPrice = p.DiscountPrice
                    
                });
            return new GetProductsReasponse
            {
                Products = result.ToList(),
                PageSize = request.PageSize,
                Page = request.Page,
                TotalCount = totalCount,
                ProductDescription = request.Description,
                CategoryName = request.CategoryName,
                ProductName = request.Name


            };
        }
    }
}
