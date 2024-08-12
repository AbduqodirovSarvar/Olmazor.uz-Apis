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
    public class GetSlideQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetSlideQuery, Slide>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Slide> Handle(GetSlideQuery request, CancellationToken cancellationToken)
        {
            var slide = await _appDbContext.Slides.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                      ?? throw new Exception("Slide not found");
            return slide;
        }
    }
}
