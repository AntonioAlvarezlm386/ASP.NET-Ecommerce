using EntityLayer;
using System.Collections.Generic;

namespace BussinesLayer.Interfaces
{
    public interface IProductService
    {
        IEnumerable<PRODUCT> GetAllProducts();
        PRODUCT GetProductByID(int id);
        void CreateProduct(PRODUCT product);
        void UpdateProduct(PRODUCT product, int id);
        void DeleteProduct(int id);
    }
}
