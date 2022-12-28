using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.RequestHelpers
{
    public class PaginationParams
    {
        private const int MaxPageSize = 20;

       public int PageNumber { get; set; } = 1;

       private int _pageSize = 9;

       public int PageSize 

       {
          get => _pageSize;
          set => _pageSize = value > MaxPageSize ? MaxPageSize : value;
       }
        
    }
}