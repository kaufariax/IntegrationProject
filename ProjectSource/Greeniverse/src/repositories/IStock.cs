using Greeniverse.src.dtos;
using Greeniverse.src.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Greeniverse.src.repositories.implementations
{
    /// <summary>
    /// <para>Resume: Interface responsible for representing CRUD actions stock</para>
    /// <para>Version: 1.0</para>
    /// <para>Date: 05/13/2022</para>
       /// </summary>
    public interface IStock
    {
        Task NewProductAsync(NewStockDTO Product);
        Task UpdateProductAsync(UpdateStockDTO Updateproduct);
        Task DeleteProductAsync(int id);
        Task <StockModel> GetProductByIdAsync(int id);
        Task<List<StockModel>> GetAllProductsStockAsync();
        Task<List<ShoppingCartModel>> GetProductsBySearchAsync(string type, string description, string productName);
    }
}

    

