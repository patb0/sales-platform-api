using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SalesPlatform.Application.Exceptions;
using SalesPlatform.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Queries
{
    public class GetOpinionsByProductIdQueryHandler : IRequestHandler<GetOpinionsByProductIdQuery, OpinionDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetOpinionsByProductIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OpinionDto> Handle(GetOpinionsByProductIdQuery request, CancellationToken cancellationToken)
        {
            var opinions = await _context.Opinions
                .Where(x => x.ProductId == request.ProductId)
                .ToListAsync(cancellationToken);

            if (opinions.Count == 0)
            {
                throw new NotFoundOpinionException(request.ProductId);
            }

            //map opinions from db to viewmodel
            var opinionsVM = _mapper.Map<ICollection<OpinionViewModel>>(opinions);

            //rating avg
            var averageRating = 0;

            foreach (var opinion in opinionsVM)
            {
                averageRating += opinion.Rating;
            }

            var opinionDto = new OpinionDto
            {
                AverageRating = averageRating / opinionsVM.Count,
                Opinions = opinionsVM
            };

            return opinionDto;
        }
    }
}
