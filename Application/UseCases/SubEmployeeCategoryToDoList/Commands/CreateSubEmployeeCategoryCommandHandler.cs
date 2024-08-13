using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SubEmployeeCategoryToDoList.Commands
{
    public class CreateSubEmployeeCategoryCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateSubEmployeeCategoryCommand, SubEmployeeCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<SubEmployeeCategory> Handle(CreateSubEmployeeCategoryCommand request, CancellationToken cancellationToken)
        {
            var subEmployeeCategory = _mapper.Map<SubEmployeeCategory>(request);

            await _appDbContext.SubEmployeeCategories.AddAsync(subEmployeeCategory, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return subEmployeeCategory;
        }
    }
}
