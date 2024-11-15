using AutoMapper;
using GeekShopping.Web.DTO;
using GeekShopping.Web.Models;

namespace GeekShopping.Web.Data
{
  public class AutoMapperConfiguration
  {
    public static MapperConfiguration RegisterMaps()
    {
      return new MapperConfiguration((config) =>
      {
        config.CreateMap<Product, ProductDTO>().ReverseMap();
        config.CreateMap<Coupon, CouponDTO>().ReverseMap();
        config.CreateMap<CartHeader, CartHeaderDTO>().ReverseMap();
        config.CreateMap<CartDetail, CartDetailDTO>().ReverseMap();
        config.CreateMap<Cart, CartDTO>().ReverseMap();
        config.CreateMap<OrderHeader, OrderHeaderDTO>().ReverseMap();
        config.CreateMap<OrderDetail, OrderDetailDTO>().ReverseMap();
      });
    }
  }
}