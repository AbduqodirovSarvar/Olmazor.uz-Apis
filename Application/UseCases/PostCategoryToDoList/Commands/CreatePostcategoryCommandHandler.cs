using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostCategoryToDoList.Commands
{
    public class CreatePostcategoryCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreatePostCategoryCommand, PostCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<PostCategory> Handle(CreatePostCategoryCommand request, CancellationToken cancellationToken)
        {
            var postCategory = _mapper.Map<PostCategory>(request);

            await _appDbContext.PostCategories.AddAsync(postCategory, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return postCategory;
        }
    }
}
