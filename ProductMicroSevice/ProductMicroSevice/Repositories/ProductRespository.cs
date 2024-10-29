using Microsoft.EntityFrameworkCore;
using ProductMicroSevice.DBContext;
using ProductMicroSevice.Models;
using System.Collections.Generic;

//namespace ProductMicroSevice.Repositories
//{
//    public class ProductRepository : IProductRepository
//    {
//        private readonly ProductContext _dbContext;

        //public ProductRepository(ProductContext dbContext)
        //{
        //    _dbContext = dbContext; 
        //}

        //public void DeleteProduct(int productId)
        //{
        //    var product = _dbContext.Products.Find(productId);
        //    if (product != null) 
        //    {
        //        _dbContext.Products.Remove(product);
        //        Save();
        //    }
        //}

        //public Product GetProductByID(int productId)
        //{
        //    return _dbContext.Products.Find(productId);
        //}

        //public IEnumerable<Product> GetProducts()
        //{
        //    return _dbContext.Products.ToList();
        //}

        //public void InsertProduct(Product product)
        //{
        //    _dbContext.Products.Add(product); // Specified Products to avoid ambiguity
        //    Save();
        //}

        //public void Save()
        //{
        //    _dbContext.SaveChanges();
        //}

        //public void UpdateProduct(Product product)
        //{
        //    _dbContext.Entry(product).State = EntityState.Modified;
        //    Save();
        //}




namespace ProductMicroSevice.Repositories
    {
        public class ProductRepository : IProductRepository
        {
            private readonly ProductContext _dbContext;

            public ProductRepository(ProductContext dbContext)
            {
                _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            }

            public void DeleteProduct(int productId)
            {
                var product = _dbContext.Products.Find(productId);
                if (product != null) // Null check to avoid potential errors
                {
                    _dbContext.Products.Remove(product);
                    Save();
                }
            }

            public Product GetProductByID(int productId)
            {
                return _dbContext.Products.Find(productId);
            }

        public Product GetProductById(int ProductId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
            {
                return _dbContext.Products.ToList();
            }

            public void InsertProduct(Product product)
            {
                if (product == null) throw new ArgumentNullException(nameof(product));
                _dbContext.Products.Add(product);
                Save();
            }

            public void Save()
            {
                _dbContext.SaveChanges();
            }

            public void UpdateProduct(Product product)
            {
                if (product == null) throw new ArgumentNullException(nameof(product));
                _dbContext.Entry(product).State = EntityState.Modified;
                Save();
            }
        }

 }
