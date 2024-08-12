using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SlideToDoList.Commands
{
    public class DeleteSlideCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteSlideCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteSlideCommand request, CancellationToken cancellationToken)
        {
            var slide = await _appDbContext.Slides.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                  ?? throw new Exception("Slide not found");

            _appDbContext.Slides.Remove(slide);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
