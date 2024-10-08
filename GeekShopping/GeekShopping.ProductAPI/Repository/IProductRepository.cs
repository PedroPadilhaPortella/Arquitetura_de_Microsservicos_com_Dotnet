using GeekShopping.ProductAPI.DTO;

namespace GeekShopping.ProductAPI.Repository
{
  public interface IProductRepository
  {
    Task<IEnumerable<ProductDTO>> FindAll();
    Task<ProductDTO> FindById(long id);
    Task<ProductDTO> Create(ProductDTO productDTO);
    Task<ProductDTO> Update(ProductDTO productDTO);
    Task<bool> Delete(long id);
  }
}