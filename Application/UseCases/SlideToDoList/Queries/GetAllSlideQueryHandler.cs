using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SlideToDoList.Queries
{
    public class GetAllSlideQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllSlideQuery, List<Slide>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<Slide>> Handle(GetAllSlideQuery request, CancellationToken cancellationToken)
        {
            var slides = await _appDbContext.Slides.ToListAsync(cancellationToken);
            return slides;
        }
    }
}
