using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Extensions
{
    public static class ProductExtension
    {
        public static IQueryable<Product> Sort(this IQueryable<Product> query, string orderBy)
        {
              if(string.IsNullOrWhiteSpace(orderBy)) return query.OrderBy(p => p.Title);

             query = orderBy switch
             {
               "price" => query.OrderBy(p=> p.Price),
               "priceDesc" => query.OrderByDescending(p => p.Price),
               _ => query.OrderBy(p => p.Title)
            }; 
          return query;
        }

        public static IQueryable<Product> Search(this IQueryable<Product> query, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) return query;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return query.Where(p => p.Title.ToLower().Contains(lowerCaseSearchTerm));
        }

        public static IQueryable<Product> Filter(this IQueryable<Product> query, string brands)
        { 
            var brandList = new List<string>();
                
            if (!string.IsNullOrEmpty(brands))
                brandList.AddRange(brands.ToLower().Split(",").ToList());

            query = query.Where(p => brandList.Count == 0 || brandList.Contains(p.Brand_Name.ToLower()));

            return query;
        }
            
            
        
    }
}