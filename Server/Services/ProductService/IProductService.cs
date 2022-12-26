namespace invite.Server.Services.ProductService
{
    public interface IProductService
    {
        //Returns all the products from the SQL server
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        //Return a single product from the SQL server
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}