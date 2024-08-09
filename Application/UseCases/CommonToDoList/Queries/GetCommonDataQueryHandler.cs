using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries
{
    public class GetCommonDataQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetCommonDataQuery, CommonViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public Task<CommonViewModel> Handle(GetCommonDataQuery request, CancellationToken cancellationToken)
        {
            

            throw new NotImplementedException();
        }
    }
}
