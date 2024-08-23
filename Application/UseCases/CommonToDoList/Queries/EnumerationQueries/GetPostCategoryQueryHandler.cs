using Application.Models.ViewModels;
using AutoMapper;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries.EnumerationQueries
{
    public class GetPostCategoryQueryHandler(
        IMapper mapper
        ) : IRequestHandler<GetPostCategoryQuery, List<EnumViewModel>>
    {
        private readonly IMapper _mapper = mapper;

        public Task<List<EnumViewModel>> Handle(GetPostCategoryQuery request, CancellationToken cancellationToken)
        {
            var postCategories = Enum.GetValues(typeof(PostCategory)).Cast<PostCategory>();
            return Task.FromResult(_mapper.Map<List<EnumViewModel>>(postCategories));
        }
    }
}
