using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesPlatform.Application.Opinions.Queries.GetOpinionsByProductId
{
    public class GetOpinionsByProductIdQuery : IRequest<OpinionDto>
    {
        public int ProductId { get; set; }
    }
}
