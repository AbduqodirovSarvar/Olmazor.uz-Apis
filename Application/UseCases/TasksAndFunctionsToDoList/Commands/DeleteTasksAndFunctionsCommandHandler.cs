using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.TasksAndFunctionsToDoList.Commands
{
    public class DeleteTasksAndFunctionsCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteTasksAndFunctionsCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteTasksAndFunctionsCommand request, CancellationToken cancellationToken)
        {
            var taskOrFunction = await _appDbContext.TasksAndFunctions.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                       ?? throw new Exception("Task or Function not found");

            _appDbContext.TasksAndFunctions.Remove(taskOrFunction);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
