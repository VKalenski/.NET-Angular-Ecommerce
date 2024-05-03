#region Usings
using API.Dtos;
using AutoMapper;
using Core.Entities;
#endregion

namespace API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        #region Fields
        private readonly IConfiguration _config;
        #endregion

        #region Ctor
        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }
        #endregion

        #region Methods
        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
        #endregion
    }
}