using Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Common.Queries
{
    public class GetCommonDataQuery : IRequest<CommonViewModel>
    {
        public GetCommonDataQuery() { }
    }
}
