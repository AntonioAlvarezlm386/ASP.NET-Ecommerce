using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayout.Interfaces
{
    public interface IProductService
    {
        IEnumerable<PRODUCT> GetAllProducts();
        PRODUCT GetProductByID(int id);
        void CreateProduct(PRODUCT product);
        void UpdateProduct(PRODUCT product);
        void DeleteProduct(int id);
    }
}
