#region Usings
using API.Dtos;
using AutoMapper;
using Core.Entities.OrderAggregate;
#endregion

namespace API.Helpers
{
    public class OrderItemUrlResolver : IValueResolver<OrderItem, OrderItemDto, string>
    {
        #region Fields
        private readonly IConfiguration _config;
        #endregion

        #region Ctor
        public OrderItemUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        #endregion

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ItemOrdered.PictureUrl))
            {
                return _config["ApiUrl"] + source.ItemOrdered.PictureUrl;
            }

            return null;
        }
    }
}