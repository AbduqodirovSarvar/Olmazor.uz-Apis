using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostCategoryToDoList.Queries
{
    public class GetAllPostCategoryQuery : IRequest<List<PostCategory>>
    {
        public GetAllPostCategoryQuery() { }
    }
}
