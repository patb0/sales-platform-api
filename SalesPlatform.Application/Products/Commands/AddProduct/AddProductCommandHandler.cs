using AutoMapper;
using MediatR;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using SalesPlatform.Application.Services;
using SalesPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Products.Commands.AddProduct
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUser;
        private readonly IImageUpload _imageUpload;

        public AddProductCommandHandler(
            IApplicationDbContext context,
            IMapper mapper,
            ICurrentUserService currentUser, 
            IImageUpload imageUpload)
        {
            _context = context;
            _mapper = mapper;
            _currentUser = currentUser;
            _imageUpload = imageUpload;
        }

        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.Product);
            product.UserId = _currentUser.UserId;

            _context.Products.Add(product);
            _context.SaveChangesWithAuditable();

            

            //add images to entity
            var images = new List<Image>();

            foreach(var image in request.Images)
            {
                var uploadImageResult = await _imageUpload.UploadImageAsync(image);

                var newImage = new Image()
                {
                    Url = uploadImageResult.Url.ToString(),
                    Height = uploadImageResult.Height,
                    Width = uploadImageResult.Width,
                    ProductId = product.Id,
                };

                images.Add(newImage);
            }

            _context.Images.AddRange(images);
            _context.SaveChanges();
           
            return product.Id;
        }
    }
}
