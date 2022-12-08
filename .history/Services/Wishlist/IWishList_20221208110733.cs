using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Dtos.WishList;

namespace WebAPI.Services.Wishlist
{
    public interface IWishList
    {
        Task<ServiceResponse<List<GetWishListItemDto>>> GetWishList();
        Task<ServiceResponse<List<GetWishListItemDto>>> AddWishListItem(GetWishListItemDto newProduct);

        Task<ServiceResponse<GetWishListItemDto>> UpdateWishListItem(WishList updatedProduct);
        Task<ServiceResponse<List<GetWishListItemDto>> DeleteWishListItem(int id);
    }
}