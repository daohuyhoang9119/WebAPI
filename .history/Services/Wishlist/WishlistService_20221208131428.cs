using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.WishList;

namespace WebAPI.Services.Wishlist
{
    public class WishlistService : IWishList
    {
        public Task<ServiceResponse<List<GetWishListItemDto>>> AddWishListItem(GetWishListItemDto newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetWishListItemDto>>> DeleteWishListItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetWishListItemDto>>> GetWishList()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetWishListItemDto>> UpdateWishListItem(WishList updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}