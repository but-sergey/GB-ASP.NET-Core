using System;
using System.Collections.Generic;
using System.Net.Http;
using WebStore.Domain;
using WebStore.Domain.Entities;
using WebStore.Interfaces;
using WebStore.Interfaces.Services;
using WebStore.WebAPI.Clients.Base;

namespace WebStore.WebAPI.Clients.Products
{
    public class ProductsClient : BaseClient, IProductData
    {
        public ProductsClient(HttpClient Client) : base(Client, WebAPIAddress.Products) { }

        public Brand GetBrand(int id) { throw new NotImplementedException(); }

        public IEnumerable<Brand> GetBrands() { throw new NotImplementedException(); }

        public Product GetProductById(int Id) { throw new NotImplementedException(); }

        public IEnumerable<Product> GetProducts(ProductFilter Filter = null) { throw new NotImplementedException(); }

        public Section GetSection(int id) { throw new NotImplementedException(); }

        public IEnumerable<Section> GetSections() { throw new NotImplementedException(); }
    }
}
