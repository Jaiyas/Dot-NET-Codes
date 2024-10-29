using ProductMicroSevice.Models;

namespace ProductMicroSevice.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int ProductId);

        void InsertProduct(Product Product);

        void DeleteProduct(int ProductTd);

        void UpdateProduct(Product Product);

       
    }
}
