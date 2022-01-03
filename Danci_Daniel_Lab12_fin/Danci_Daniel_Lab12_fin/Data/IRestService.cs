using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Danci_Daniel_Lab12_fin.Models;

namespace Danci_Daniel_Lab12_fin.Data
{
    public interface IRestService
    {
       Task<List<ShopList>> RefreshDataAsync();
       Task SaveShopListAsync(ShopList item, bool isNewItem);
      Task DeleteShopListAsync(int id);
    }
}
