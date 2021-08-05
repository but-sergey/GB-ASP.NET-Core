using System.Linq;
using WebStore.Domain;
using WebStore.Domain.Entities;
using WebStore.Domain.ViewModels;
using WebStore.Interfaces.Services;
using WebStore.Services.Mapping;

namespace WebStore.Services.Services
{
    public class CartService : ICartService
    {
        private readonly IProductData _ProductData;
        private readonly ICartStore _CartStore;

        public CartService(ICartStore CartStore, IProductData ProductData)
        {
            _ProductData = ProductData;
            _CartStore = CartStore;
        }

        public void Add(int Id)
        {
            var cart = _CartStore.Cart;

            var item = cart.Items.FirstOrDefault(i => i.ProductId == Id);
            if (item is null)
                cart.Items.Add(new CartItem { ProductId = Id });
            else
                item.Quantity++;

            _CartStore.Cart = cart;
        }

        public void Clear()
        {
            var cart = _CartStore.Cart;

            cart.Items.Clear();

            _CartStore.Cart = cart;
        }

        public void Decrement(int Id)
        {
            var cart = _CartStore.Cart;

            var item = cart.Items.FirstOrDefault(i => i.ProductId == Id);
            if (item is null) return;

            if (item.Quantity > 0)
                item.Quantity--;

            if (item.Quantity <= 0)
                cart.Items.Remove(item);

            _CartStore.Cart = cart;
        }

        public void Remove(int Id)
        {
            var cart = _CartStore.Cart;

            var item = cart.Items.FirstOrDefault(i => i.ProductId == Id);
            if (item is null) return;

            cart.Items.Remove(item);

            _CartStore.Cart = cart;
        }

        public CartViewModel GetViewModel()
        {
            var cart = _CartStore.Cart;
            var products = _ProductData.GetProducts(new ProductFilter
            {
                Ids = cart.Items.Select(item => item.ProductId).ToArray()
            });

            var products_views = products.Products.ToView().ToDictionary(p => p.Id);

            return new CartViewModel
            {
                Items = cart.Items
                .Where(item => products_views.ContainsKey(item.ProductId))
                .Select(item => (products_views[item.ProductId], item.Quantity))
            };
        }
    }
}
